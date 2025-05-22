using System.Diagnostics.Metrics;

namespace Desafio_3
{
    public partial class SimuladorRed : Form
    {
        private List<Dispositivo> dispositivos = new List<Dispositivo>();
        private List<NodoVisual> nodosVisuales = new List<NodoVisual>();
        private Random rnd = new Random();
        private List<Conexion> conexiones = new List<Conexion>();
        private NodoVisual nodoSeleccionado1 = null;
        private NodoVisual nodoSeleccionado2 = null;
        private Image imgPC;
        private Image imgRouter;

        public SimuladorRed()
        {
            InitializeComponent();
            cmbTipoDispositivo.Items.Add("PC");
            cmbTipoDispositivo.Items.Add("Router");
            cmbTipoDispositivo.SelectedIndex = 0;
            nodoSeleccionado1 = null;
            nodoSeleccionado2 = null;
            panelDibujo.Invalidate();
            ActualizarLista();
        }

        private void btnAgregarDispositivo_Click(object sender, EventArgs e)
        {
            string tipo = cmbTipoDispositivo.SelectedItem.ToString();
            FormularioIP frm = new FormularioIP(tipo);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                Dispositivo nuevo;
                if (tipo == "PC")
                    nuevo = new PC(frm.DireccionIP);
                else
                    nuevo = new Router(frm.DireccionIP, frm.DireccionRed);

                dispositivos.Add(nuevo);

                // Posición aleatoria
                Point posicion = new Point(rnd.Next(20, panelDibujo.Width - 60), rnd.Next(20, panelDibujo.Height - 60));
                nodosVisuales.Add(new NodoVisual(nuevo, posicion));

                // Agrega directamente el objeto al ListBox
                lstDispositivos.Items.Add(nuevo);

                panelDibujo.Invalidate(); // Redibuja
            }
        }

        private void btnEliminarDispositivo_Click(object sender, EventArgs e)
        {
            if (lstDispositivos.SelectedIndex >= 0)
            {
                // Eliminar el dispositivo seleccionado
                Dispositivo dispositivoAEliminar = dispositivos[lstDispositivos.SelectedIndex];
                dispositivos.RemoveAt(lstDispositivos.SelectedIndex);

                // Eliminar conexiones relacionadas
                conexiones.RemoveAll(c => c.A == dispositivoAEliminar || c.B == dispositivoAEliminar);

                // Eliminar nodo visual relacionado
                nodosVisuales.RemoveAll(n => n.Dispositivo == dispositivoAEliminar);

                // Actualizar la lista visual
                ActualizarLista();

                // Redibujar el panel
                panelDibujo.Invalidate();
            }
        }

        private void btnEditarIP_Click(object sender, EventArgs e)
        {
            if (lstDispositivos.SelectedIndex >= 0)
            {
                Dispositivo d = dispositivos[lstDispositivos.SelectedIndex];
                string tipo = d is PC ? "PC" : "Router";
                FormularioIP frm = new FormularioIP(tipo);

                frm.DireccionIP = d.DireccionIP;
                if (d is Router r)
                    frm.DireccionRed = r.DireccionRed;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    d.DireccionIP = frm.DireccionIP;
                    if (d is Router rtr)
                        rtr.DireccionRed = frm.DireccionRed;

                    ActualizarLista();
                }
            }
        }
        private void ActualizarLista()
        {
            lstDispositivos.Items.Clear();
            foreach (var d in dispositivos)
                lstDispositivos.Items.Add(d.ToString());
        }
        private bool HayConexion(Dispositivo origen, Dispositivo destino, HashSet<Dispositivo> visitados)
        {
            if (origen == destino) return true;
            visitados.Add(origen);

            foreach (var con in conexiones)
            {
                Dispositivo vecino = null;

                if (con.A == origen && !visitados.Contains(con.B)) vecino = con.B;
                else if (con.B == origen && !visitados.Contains(con.A)) vecino = con.A;

                if (vecino != null && HayConexion(vecino, destino, visitados))
                    return true;
            }

            return false;
        }

        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fuente = new Font("Arial", 8);
            Pen lapiz = new Pen(Color.Black, 2);
            Pen resaltado = new Pen(Color.Red, 3);

            // Dibujar conexiones
            Pen linea = new Pen(Color.DarkGray, 2);
            foreach (var con in conexiones)
            {
                var nodoA = nodosVisuales.FirstOrDefault(n => n.Dispositivo == con.A);
                var nodoB = nodosVisuales.FirstOrDefault(n => n.Dispositivo == con.B);
                if (nodoA != null && nodoB != null)
                {
                    Point p1 = new Point(nodoA.Posicion.X + 25, nodoA.Posicion.Y + 25);
                    Point p2 = new Point(nodoB.Posicion.X + 25, nodoB.Posicion.Y + 25);
                    g.DrawLine(linea, p1, p2);
                }
            }

            // Dibujar los dispositivos con imágenes
            foreach (var nodo in nodosVisuales)
            {
                Rectangle rect = new Rectangle(nodo.Posicion.X, nodo.Posicion.Y, 50, 50);

                Image imagen = (nodo.Dispositivo is PC) ? imgPC : imgRouter;

                if (imagen != null)
                {
                    g.DrawImage(imagen, rect);
                }
                else
                {
                    // Si no hay imagen, se puede dibujar una elipse como marcador visual
                    g.FillEllipse(Brushes.Gray, rect);
                    g.DrawEllipse(lapiz, rect);
                }

                if (nodo == nodoSeleccionado1 || nodo == nodoSeleccionado2)
                {
                    g.DrawRectangle(resaltado, rect);
                }

                // Mostrar dirección IP
                g.DrawString(nodo.Dispositivo.DireccionIP, fuente, Brushes.Black, nodo.Posicion.X, nodo.Posicion.Y + 55);
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado1 != null && nodoSeleccionado2 != null)
            {
                var disp1 = nodoSeleccionado1.Dispositivo;
                var disp2 = nodoSeleccionado2.Dispositivo;

                // Verificar si ya están conectados
                var conexionExistente = conexiones.FirstOrDefault(c =>
                    (c.A == disp1 && c.B == disp2) || (c.A == disp2 && c.B == disp1));

                if (conexionExistente != null)
                {
                    // Si ya están conectados, desconectar
                    conexiones.Remove(conexionExistente);
                    MessageBox.Show("Dispositivos desconectados correctamente.");
                }
                else
                {
                    // Si no están conectados, conectar
                    conexiones.Add(new Conexion(disp1, disp2));
                    MessageBox.Show("Dispositivos conectados correctamente.");
                }

                // Limpiar selección
                nodoSeleccionado1 = null;
                nodoSeleccionado2 = null;
                panelDibujo.Invalidate();
            }
            else
            {
                MessageBox.Show("Debes seleccionar dos dispositivos antes de conectarlos o desconectarlos.");
            }
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado1 == null || nodoSeleccionado2 == null)
            {
                MessageBox.Show("Debes seleccionar dos dispositivos en el panel.");
                return;
            }

            var origen = nodoSeleccionado1.Dispositivo;
            var destino = nodoSeleccionado2.Dispositivo;

            bool conectado = HayConexion(origen, destino, new HashSet<Dispositivo>());

            if (conectado)
            {
                MessageBox.Show($"Ping exitoso:\n{origen.DireccionIP} → {destino.DireccionIP}");
            }
            else
            {
                MessageBox.Show($"No hay conexión entre:\n{origen.DireccionIP} y {destino.DireccionIP}");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo de red (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        foreach (var d in dispositivos)
                        {
                            if (d is PC)
                                sw.WriteLine($"PC,{d.DireccionIP}");
                            else if (d is Router r)
                                sw.WriteLine($"Router,{r.DireccionIP},{r.DireccionRed}");
                        }

                        sw.WriteLine("---");

                        foreach (var c in conexiones)
                            sw.WriteLine($"{c.A.DireccionIP},{c.B.DireccionIP}");
                    }

                    MessageBox.Show("Red guardada correctamente.");
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivo de red (*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    dispositivos.Clear();
                    conexiones.Clear();
                    nodosVisuales.Clear();

                    var lineas = File.ReadAllLines(ofd.FileName);
                    int i = 0;

                    // Leer dispositivos
                    for (; i < lineas.Length && lineas[i] != "---"; i++)
                    {
                        var partes = lineas[i].Split(',');
                        if (partes[0] == "PC")
                        {
                            var pc = new PC(partes[1]);
                            dispositivos.Add(pc);
                            nodosVisuales.Add(new NodoVisual(pc, new Point(rnd.Next(50, 400), rnd.Next(50, 300))));
                        }
                        else if (partes[0] == "Router")
                        {
                            var r = new Router(partes[1], partes[2]);
                            dispositivos.Add(r);
                            nodosVisuales.Add(new NodoVisual(r, new Point(rnd.Next(50, 400), rnd.Next(50, 300))));
                        }
                    }

                    // Leer conexiones
                    for (i++; i < lineas.Length; i++)
                    {
                        var partes = lineas[i].Split(',');
                        var d1 = dispositivos.First(d => d.DireccionIP == partes[0]);
                        var d2 = dispositivos.First(d => d.DireccionIP == partes[1]);
                        conexiones.Add(new Conexion(d1, d2));
                    }

                    ActualizarLista();
                    panelDibujo.Invalidate();
                    MessageBox.Show("Red cargada correctamente.");
                }
            }
        }

        private void panelDibujo_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var nodo in nodosVisuales)
            {
                Rectangle rect = new Rectangle(nodo.Posicion.X, nodo.Posicion.Y, 50, 50);
                if (rect.Contains(e.Location))
                {
                    if (nodoSeleccionado1 == null)
                    {
                        nodoSeleccionado1 = nodo;
                    }
                    else if (nodoSeleccionado2 == null && nodo != nodoSeleccionado1)
                    {
                        nodoSeleccionado2 = nodo;
                    }
                    else
                    {
                        nodoSeleccionado1 = nodo;
                        nodoSeleccionado2 = null;
                    }

                    panelDibujo.Invalidate();
                    break;
                }
            }
        }

        private void SimuladorRed_Load(object sender, EventArgs e)
        {
            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaRouter = Path.Combine(escritorio, "ROUTER.png");
            string rutaPC = Path.Combine(escritorio, "COMPUTER.png");

            if (File.Exists(rutaPC))
            {
                imgPC = Image.FromFile(rutaPC);
            }
            else
            {
                MessageBox.Show("No se encontró la imagen COMPUTER.png en el escritorio.");
            }

            if (File.Exists(rutaRouter))
            {
                imgRouter = Image.FromFile(rutaRouter);
            }
            else
            {
                MessageBox.Show("No se encontró la imagen ROUTER.png en el escritorio.");
            }
        }
    }
}
