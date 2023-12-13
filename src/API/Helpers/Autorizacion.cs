namespace API.Helpers;
    public class Autorizacion{
        
        public enum Roles{
            Administrador,
            Empresa
        }
        public const Roles rol_predeterminado = Roles.Empresa;

}
