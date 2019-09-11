namespace HRSystem.Models
{
    public class Config
    {
        public Default_Config Default_Config { get; set; }
        public Integration_Setup Integration_Setup { get; set; }
        public Integration_Service[] Integration_Services { get; set; }
        public string URL { get; set; }
    }

    public class Default_Config
    {
        public string Company_Name { get; set; }
        public string Type { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsForRemit { get; set; }
        public Integration_Service[] Integration_Services { get; set; }
    }

    public class Integration_Setup
    {
        public string Base_URL { get; set; }
        public string Service_Instance { get; set; }
        public string Integration_Name { get; set; }
        public string Domain { get; set; }
    }

    public class Integration_Service
    {
        public string Integration_Type { get; set; }
        public string Service_Name { get; set; }
        public string Type { get; set; }
        public string Company_Name { get; set; }
    }
}
