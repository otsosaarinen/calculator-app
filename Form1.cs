namespace calculator_app;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{

	}

	private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
	{

	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{

	}

	List<double> numbers = new List<double>();
	string operation = "";

	private void button1_Click(object sender, EventArgs e)
	{
		textBox1.Text += 1;

	}

	private void button2_Click(object sender, EventArgs e)
	{
		textBox1.Text += 2;
	}

	private void button3_Click(object sender, EventArgs e)
	{
		textBox1.Text += 3;
	}

	private void button4_Click(object sender, EventArgs e)
	{
		textBox1.Text += 4;
	}

	private void button5_Click(object sender, EventArgs e)
	{
		textBox1.Text += 5;
	}

	private void button6_Click(object sender, EventArgs e)
	{
		textBox1.Text += 6;
	}

	private void button7_Click(object sender, EventArgs e)
	{
		textBox1.Text += 7;
	}

	private void button8_Click(object sender, EventArgs e)
	{
		textBox1.Text += 8;
	}

	private void button9_Click(object sender, EventArgs e)
	{
		textBox1.Text += 9;
	}

	private void button0_Click(object sender, EventArgs e)
	{
		textBox1.Text += 0;
	}

	private void buttonclear_Click(object sender, EventArgs e)
	{
		textBox1.Text = string.Empty;
		operation = "";
		numbers.Clear();
	}

	private void buttonplus_Click(object sender, EventArgs e)
	{
		operation = "+";
		numbers.Add(double.Parse(textBox1.Text));
		textBox1.Clear();
	}

	private void buttonminus_Click(object sender, EventArgs e)
	{
		operation = "-";
		numbers.Add(double.Parse(textBox1.Text));
		textBox1.Clear();
	}

	private void buttontimes_Click(object sender, EventArgs e)
	{
		operation = "*";
		numbers.Add(double.Parse(textBox1.Text));
		textBox1.Clear();
	}

	private void buttondivided_Click(object sender, EventArgs e)
	{
		operation = "/";
		numbers.Add(double.Parse(textBox1.Text));
		textBox1.Clear();
	}

	private void buttoncalculate_Click(object sender, EventArgs e)
	{
		double result = 0;

		numbers.Add(double.Parse(textBox1.Text));

		for (int i = 0; i < numbers.Count - 1; i++)
		{

			switch (operation) {
				case "+": result = result + numbers[i] + numbers[i + 1];
					break;
				case "-":
					result = result - numbers[i] - numbers[i + 1];
					break;
			}
			
		}
		
		textBox1.Text = result.ToString();
		operation = "";
		numbers.Clear();
	}
}
