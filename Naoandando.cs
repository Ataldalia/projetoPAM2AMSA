namespace AMS_EXERCI_23
{
    public class Naoandando : Pessoa
        {
         public Naoandando(int id , string? Name):base(ID , Name)
         {
              this._id + id;
              this._name = Name;
         }
         public override void Anda()
         {
            Console.WriteLine(_name+ "não anda ");
         }
        }
}