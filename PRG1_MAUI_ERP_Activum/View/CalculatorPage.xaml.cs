namespace PRG1_MAUI_ERP_Activum.View;

public partial class CalculatorPage : ContentPage
{
    double firstNumber = 0;
    string currentOperation = " ";
    string currentText = "0";
    string lastCalculation = " ";

    public CalculatorPage()
    {
        InitializeComponent();
        Display.Text = "0";
        LiveInputLabel.Text = " ";
        HistoryLabel.Text = " ";
    }

    private void OnNumberClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string number = button.Text;

        if (currentText == "0" && number != ".")
            currentText = " ";

        if (number == ".")
        {
            if (!currentText.Contains("."))
                currentText = currentText + ".";


        }
        else
        {
            currentText = currentText + number;

        }

        Display.Text = currentText;
        LiveInputLabel.Text = currentText;


    }

    private void OnOperatorClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string newOperation = button.Text;

        LiveInputLabel.Text = lastCalculation + " " + newOperation;

        if (currentOperation != " " && currentText != "Error")
        {
            OnEqualsClicked(null, null);
        }

        firstNumber = double.Parse(currentText);
        currentOperation = newOperation;
        lastCalculation = currentText;
        currentText = "0";


    }

    private void OnEqualsClicked(object sender, EventArgs e)
    {
        if (currentOperation == " " || currentText == "Error") return;

        double secondNumber = double.Parse(currentText);
        double result = 0;

        if (currentOperation == "+")
            result = firstNumber + secondNumber;
        else if (currentOperation == "-")
            result = firstNumber - secondNumber;
        else if (currentOperation == "×")
            result = firstNumber * secondNumber;
        else if (currentOperation == "÷")
        {
            if (secondNumber == 0)
            {
                currentText = "Error";
                Display.Text = "Error";
                HistoryLabel.Text = "CANNOT DIVIDE BY ZERO!!!";
                LiveInputLabel.Text = " ";
                currentOperation = " ";
                return;
            }
            result = firstNumber / secondNumber;

        }

        currentText = result.ToString();
        Display.Text = currentText;
        HistoryLabel.Text = firstNumber + " " + currentOperation + " " + secondNumber + " = " + currentText;
        LiveInputLabel.Text = " ";
        currentOperation = " ";


    }

    private void OnClearClicked(object sender, EventArgs e)
    {
        firstNumber = 0;
        currentText = "0";
        currentOperation = " ";
        lastCalculation = " ";
        Display.Text = "0";
        HistoryLabel.Text = " ";
        LiveInputLabel.Text = " ";
    }

    private void OnClearEntryClicked(object sender, EventArgs e)
    {
        currentText = "0";
        Display.Text = "0";
        LiveInputLabel.Text = " ";
    }

    private void OnBackspaceClicked(object sender, EventArgs e)
    {
        if (currentText.Length > 1)
        {
            currentText = currentText.Substring(0, currentText.Length - 1);
            Display.Text = currentText;
            LiveInputLabel.Text = currentText;
        }
        else
        {
            currentText = "0";
            Display.Text = "0";
            LiveInputLabel.Text = " ";
        }
    }

    private void OnDecimalClicked(object sender, EventArgs e)
    {
        if (!currentText.Contains("."))
        {
            currentText = currentText + ".";
            Display.Text = currentText;
            LiveInputLabel.Text = currentText;


        }
    }
}
