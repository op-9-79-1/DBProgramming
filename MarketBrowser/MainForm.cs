using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Windows.Forms;

namespace MarketBrowser
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private string[] parseCSVLine(string line)
		{
			int firstindex = 0; // " 의 가 나온 첫번째 인덱스 저장
			int secondindex = 0; // "가 나온 두번째 인덱스 저장
			string sum_string = ""; // 인덱스끼리 합친 스트링
			int res_m = 0; // 배열을 합친만큼 for문에서 제외
			int recy = 0; // ,의 연속값을 저장

			string[] split_line = line.Split(','); // line 을 먼저 split해서 하나씩 찾기

			for (int i = 0; i < split_line.Length - res_m; i++)
			{
				if (split_line[i].Contains('"')) // i번째에 "가 포함되어 있는지 확인
				{
					
					firstindex = i; // 찾았기에 firstindex에 저장
					for (int j = i + 1; j < split_line.Length - res_m; j++) // 그 다음 인덱스를 합치는 과정
					{
						secondindex = j; // 다음 인덱스를 저장
						sum_string = split_line[firstindex] + ',' + split_line[secondindex]; // string 으로 두 인덱스를 합침
						split_line[i] = sum_string; // 합친 string을 첫 index에 저장
						recy++; //  배열의 끝부분을 땡기기 위해 +
						if (split_line[j].Contains('"')) // 만약 "를 찾았으면 종료
							break;
					}
					while (true)
					{
						for (int q = i + 1; q < split_line.Length - (1 + res_m); q++) // 배열을 직접적으로 땡기기 위해 변수 생성 후 for문
						{
							split_line[q] = split_line[q + 1]; // 배열을 땡기는 과정
						}
						res_m++; // 배열을 땡겼기 때문에 for문에서 하나씩 비우는 역할
						if (--recy == 0) // 인덱스끼리의 공백이 없을경우 종료
							break;
					}
				}
			}
			return split_line;
		}

		private List<List<string>> MakeColumnnarDataStructure()
		{
			StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open), Encoding.Default);
			string str = "";


			var line = sr.ReadLine();
			var headers = line.Split(',');


			List<List<string>> data = new List<List<string>>();
			foreach (string header in headers)
			{
				List<string> list = new List<string>();

				list.Add(header);
				data.Add(list);
			}

			while (sr.EndOfStream == false)
			{
				line = sr.ReadLine();
				var values = parseCSVLine(line);
				//var values = line.Split(',');

				for (int i = 0; i < values.Length; i++) {
					if (i == 6)
						break;
					data[i].Add(values[i]);
				}
				

			}

			//textBoxCSVViewer.Text = str;
			
			sr.Close();
			return data;
		}

		private void printColumnData_columnbased(List<List<string>> data, int columnidx)
		{
			string str = "";

			foreach (string value in data[columnidx])
			{
				str += value + "\r\n";
			}
			textBoxCSVViewer.Text = str;
		}

		private void printRowData_columnbased(List<List<string>> data)
		{
			string str = "";

			for (int row = 0; row < data[0].Count; row++)
			{
				foreach(List<string> list in data) {
					if (row == 1)
						break;
					str += list[row] + "\t";
				}
				str += "\r\n";
			}
			textBoxCSVViewer.Text = str;
		}

		private List<List<string>> MakeRowbasedDataStructure()
		{
			StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open), Encoding.Default);
			string str = "";

			var line = sr.ReadLine();
			var headers = line.Split(',');


			List<List<string>> data = new List<List<string>>();

			int row = 0;
			while (sr.EndOfStream == false)
			{
				line = sr.ReadLine();
				var values = line.Split(',');

				data.Add(values.ToList());

				if (row++ == 5)
					break;

			}

			//textBoxCSVViewer.Text = str;

			sr.Close();
			return data;
		}

		private void printRowData_rowbased(List<List<string>> data)
		{
			string str = "";
			foreach (List<string> rowlist in data)
			{
				foreach (string value in rowlist)
					str += value + "\t";
			}

			textBoxCSVViewer.Text = str;
		}

		private void printColumnData_rowbased(List<List<string>> data, int colidx)
		{
			string str = "";
			foreach (List<string> rowlist in data)
			{
				str += rowlist[colidx] + "\r\n";
			}

			textBoxCSVViewer.Text = str;
		}

		private void buttdonOpenCSV_Click(object sender, EventArgs e)
		{
			//List<List<string>> data = MakeRowbasedDataStructure();
			//printRowData_rowbased(data);
			//printColumnData_rowbased(data, 1);

			 List<List<string>> data = MakeColumnnarDataStructure();
			printColumnData_columnbased(data, 4);
			//printRowData_columnbased(data);
		}
	}
}
