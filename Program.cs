namespace AMS_EXERCI_23
{
 class Program
 {
    static void Main(string[]args)
    {
        Pessoa pessoaFísica = new Andando(222,"nami");
        pessoaFísica.Add();
         pessoaFísica.Andar();

         Pessoa pessoaJuridica = new Naoandando(333,"sanji");
         pessoaJuridica.Add();
         pessoaJuridica.Andar();
    }
 }





}
