namespace EXERCISE_CAT
{
    public abstract class Gato
    {
        public Gato()
        {
            
        }


        public decimal Peso { get; set; }
        public string tamaño { get; set; }
        public string color { get; set; }
        public string nombre { get; set; }

        public abstract void comer();
        

        
        public  void comer(int cantidad)
        {

        }
        public abstract void correr();
                
         public void correr(decimal distancia)
         {

         }

        public abstract void jugar();
    

        
        public void  jugar(string juguete)
        {

        }
    }
}