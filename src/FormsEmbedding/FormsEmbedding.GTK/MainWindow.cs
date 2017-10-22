using FormsEmbedding.Views;
using Xamarin.Forms.Platform.GTK.Extensions;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();

        global::Xamarin.Forms.Forms.Init(null);
        this.gtkBtn.Clicked += OnGtkBtnClicked;
    }

    protected void OnDeleteEvent(object sender, Gtk.DeleteEventArgs a)
	{
		Gtk.Application.Quit();
		a.RetVal = true;
	}

    private void OnGtkBtnClicked(object sender, System.EventArgs e)
    {
        var settingsView = new SettingsView().CreateContainer();
        vbox1.PackEnd(settingsView, true, true, 0);
    }
}