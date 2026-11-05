namespace Bai01_ClinicAppointment;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new frmClinicAppointment());
    }    
}
