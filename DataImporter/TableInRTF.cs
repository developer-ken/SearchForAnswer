// DataImporter.TableInRTF
using System.Data;
using System.Text;

internal class TableInRTF
{
	public static string RtfFromMetrix2d(string[][] table, int totalsize = 5000)
	{
		int metfactor = totalsize / table[0].Length;
		StringBuilder strTable = new StringBuilder();
		strTable.Append("{\\rtf1 ");
		for (int i = 0; i < table.Length; i++)
		{
			strTable.Append("\\trowd");
			for (int k = 0; k < table[i].Length; k++)
			{
				strTable.Append("\\cellx" + (k + 1) * metfactor);
			}
			strTable.Append("\\intbl ");
			for (int j = 0; j < table[i].Length - 1; j++)
			{
				strTable.Append(strToRtf(table[i][j]) + " \\cell ");
			}
			strTable.Append(strToRtf(table[i][table[i].Length - 1]) + " \\row ");
		}
		strTable.Append("\\pard");
		strTable.Append("}");
		return strTable.ToString();
	}

	public static string RtfFromDataTable(DataTable table, int totalsize = 5000)
	{
		int metfactor = totalsize / table.Columns.Count;
		StringBuilder strTable = new StringBuilder();
		strTable.Append("{\\rtf1 ");
		for (int i = 0; i < table.Rows.Count; i++)
		{
			strTable.Append("\\trowd");
			for (int k = 0; k < table.Columns.Count; k++)
			{
				strTable.Append("\\cellx" + (k + 1) * metfactor);
			}
			strTable.Append("\\intbl ");
			for (int j = 0; j < table.Columns.Count - 1; j++)
			{
				strTable.Append(strToRtf((string)table.Rows[i].ItemArray[j]) + " \\cell ");
			}
			strTable.Append(strToRtf((string)table.Rows[i].ItemArray[table.Columns.Count - 1]) + " \\row ");
		}
		strTable.Append("\\pard");
		strTable.Append("}");
		return strTable.ToString();
	}

	public static string strToRtf(string content)
	{
		Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
		char[] digital = "0123456789ABCDEF".ToCharArray();
		StringBuilder sb = new StringBuilder("");
		int inext = 1;
		byte[] bs = null;
		bs = Encoding.GetEncoding("GB2312").GetBytes(content);
		for (int i = 0; i < bs.Length; i++)
		{
			int bit = (bs[i] & 0xF0) >> 4;
			if (bs[i] > 0)
			{
				sb.Append("\\'");
			}
			else if (inext == 0)
			{
				sb.Append("\\loch\\af2\\hich\\af2\\dbch\\f31505");
				sb.Append("\\'");
				inext = 1;
			}
			else
			{
				sb.Append("\\'");
			}
			sb.Append(digital[bit]);
			bit = bs[i] & 0xF;
			sb.Append(digital[bit]);
			if (bs[i] < 0 && inext == 1)
			{
				sb.Append("\\hich\\af2\\dbch\\af31505\\loch\\f2");
				inext = 0;
			}
		}
		return sb.ToString();
	}
}
