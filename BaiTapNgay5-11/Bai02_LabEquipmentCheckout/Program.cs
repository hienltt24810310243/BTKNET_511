namespace Bai02_LabEquipmentCheckout;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new frmLabCheckout());
    }    
}
