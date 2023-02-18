namespace ConvertidorUnidades
{
    public partial class Form1 : Form


    {

        private ConvertidorService _convertidorServicio;
        public Form1()
        {
            InitializeComponent();

            _convertidorServicio= new ConvertidorService();
            cboTipo.DataSource = Enum.GetValues(typeof(TipoEnum));
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            lstDe.DataSource = Enum.GetValues(typeof(MasaEnum));
            lstA.DataSource = Enum.GetValues(typeof(MasaEnum));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtCantidadConvertir.Text = string.Empty;
            txtCantidadConvertida.Text = string.Empty;
            
            
            
            
            
            var tipo = (TipoEnum)cboTipo.SelectedItem; // castear.

            switch (tipo)
            {
                case TipoEnum.Masa:
                    lstDe.DataSource = Enum.GetValues(typeof(MasaEnum));
                    lstA.DataSource = Enum.GetValues(typeof(MasaEnum));
                    break;
                case TipoEnum.Temperatura:
                    lstDe.DataSource = Enum.GetValues(typeof(TemperaturaEnum));
                    lstA.DataSource = Enum.GetValues(typeof(TemperaturaEnum));
                    break;
                case TipoEnum.Tiempo:
                    lstDe.DataSource = Enum.GetValues(typeof(TiempoEnum));
                    lstA.DataSource = Enum.GetValues(typeof(TiempoEnum));
                    break;
                default:
                    break;
            }

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (txtCantidadConvertir.Text.Length <= 0)
                return;


            if(lstDe.SelectedItems == lstA.SelectedItems)
            {
                txtCantidadConvertida.Text = txtCantidadConvertir.Text;
            }


            var tipo = (TipoEnum) cboTipo.SelectedItem;
            double cantidad = double.Parse(txtCantidadConvertir.Text);
            double cantidadConvertida = 0;

            switch (tipo)
            {
                case TipoEnum.Masa:
                    var MasaDe = (MasaEnum)lstDe.SelectedItem;
                    var MasaA = (MasaEnum)lstA.SelectedItem;

                    cantidadConvertida = _convertidorServicio.ConvertidorMasaUnidades(MasaDe, MasaA, cantidad);
                    break;
                case TipoEnum.Temperatura:
                    cantidadConvertida = _convertidorServicio.ConvertidorTemperaturaUnidades((TemperaturaEnum)lstDe.SelectedItem, (TemperaturaEnum)lstA.SelectedItem, cantidad);
                    break;
                case TipoEnum.Tiempo:
                    cantidadConvertida = _convertidorServicio.ConvertidorTiempoUnidades((TiempoEnum)lstDe.SelectedItem, (TiempoEnum)lstA.SelectedItem, cantidad);
                    break;
                default:
                    break;
            }


            txtCantidadConvertida.Text =  cantidadConvertida.ToString();

        }
    }
}