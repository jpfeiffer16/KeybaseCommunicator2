using DevZH.UI;

public class MainWindow : Window
{

  Grid grid;
  Button button;
    
  public MainWindow(string title = "KeybaseCommunicator", int width = 500, int height = 200, bool hasMemubar = false) : base(title, width, height, hasMemubar)
  {
      InitializeComponent();
  }

  private void InitializeComponent()
  {
    //Setup grid and layout
    grid = new Grid(){ AllowPadding = true };
    this.Child = grid;



    //Setup buttons and controls
    button = new Button("Send");
    button.Click += (sender, args) =>
    {
      MessageBox.Show("This is a test", "This is a test message that is very testy in nature.");
    };


    //Add controls to the grid
    grid.Children.Add(button, 0, 0, 40, 20, 0,HorizontalAlignment.Stretch, 0, VerticalAlignment.Stretch);
  }
}
