namespace grupal1
{
    public class Candado
    {
        private bool estado;
        private int NumeroDeSerie {get; set;}

        public void cambiarEstado()
        {
            this.estado = !estado;
        }

        public bool Estado
        {
            get {
                return estado;
            }
        }

        public void girarLlave() {
            this.cambiarEstado();
        }
    }    
}