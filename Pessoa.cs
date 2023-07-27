namespace AMS_EXERCI_23
{
    public class Pessoa
    {
        protected int _id{get;set}
        protected string? _name {get;set}
          
          public Pessoa(int id, string? Name)
          {
           this._id = ID;
           this._name=Name;
          }
          public void Add()
          { 
            Console.WriteLine(_id);
            Console.WriteLine(_name+ "adicionado");

          }
          public virtual void Andar()
          {
              Console.WriteLine(_id);
            Console.WriteLine(_name+ "está andando ");

          }
    }
}