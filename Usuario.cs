namespace Aula13_Uber
{
    public class Usuario
    {
        
     //Propriedade resumida

     public string nome { get; set; }


   // Propriedade completa
     private int idade = 0;
     public int Idade
     {
         get { return idade; }
         set { 
             if(idade > 0){
                 idade = value;
             }
     }
     }

     public string Foto { get; set; } 
     private string login = "paulo@gmail.com";
     private string Senha = "12345678";

    public string LocalizacaoAtual { get; set; }
    public string TokenLogin { get; set; }

    public bool Login(string login, string senha){

     if( this.login == login && this.Senha == senha){
         TokenLogin = "djfnjwnfuihwuivheihf";
         return true;
     } 
       return false;
    }
     public void Logout(){
         TokenLogin = "";
     }

    }
}