using System;

using DevZH.UI;

public class MainWindow : Window
{

  // Form form;
  // Grid grid;
  Button sendButton;
  Entry messageArea;
  MultilineEntry messageDisplay;
  // VerticalBox vbox;
  // HorizontalBox displayLayout;
  // HorizontalBox messageLayout;
  private HorizontalBox _hBox;
  private VerticalBox _vBox;
    
  public MainWindow(string title = "KeybaseCommunicator", int width = 500, int height = 200, bool hasMemubar = false) : base(title, width, height, hasMemubar)
  {
      InitializeComponent();
  }

  private void InitializeComponent()
  {
    //Setup grid and layout
    // grid = new Grid(){ AllowPadding = true };
    // form = new Form();
    // this.Child = grid;



    // vbox = new VerticalBox();
    // displayLayout = new HorizontalBox();
    // messageLayout = new HorizontalBox();
    // vbox.Children.Add(messageLayout);

    // this.Child = vbox;

    // messageDisplay = new MultilineEntry();
    // // messageDisplay.Enabled = false;



    // //Setup buttons and controls
    // sendButton = new Button("Send");
    // sendButton.Click += (object sender, EventArgs args) =>
    // {
    //   MessageBox.Show(String.Format("You said {0}", messageArea.Text));
    // };

    // messageArea = new Entry();


    // //Add controls to the grid
    // // vbox.Children.Add(displayLayout);
    // displayLayout.Children.Add(messageDisplay);
    // messageLayout.Children.Add(messageArea);
    // messageLayout.Children.Add(sendButton);





    _hBox = new HorizontalBox() {AllowPadding = true};
    

    _vBox = new VerticalBox() {AllowPadding = true};

    this.Child = _vBox;
    

    messageDisplay = new MultilineEntry();
    _vBox.Children.Add(messageDisplay, true);

    messageArea = new Entry();
    

    sendButton = new Button("Send");

    _vBox.Children.Add(_hBox);
    _hBox.Children.Add(messageArea);
    _hBox.Children.Add(sendButton);






  }
}
