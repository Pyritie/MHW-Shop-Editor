using MHWShopEditor.Properties;

namespace MHWShopEditor
{
	// I moved this stuff out into its own file for tidiness
	public partial class MainWindow
	{
		// these would be better as enums
		private const int c_insertTop = 0;
		private const int c_insertBottom = 1;

		private const int c_sortByID = 0;
		private const int c_sortByName = 1;

		private const int c_filterContains = 0;
		private const int c_filterWhole = 1;
		private const int c_filterHide = 2;

		public bool InsertTop
		{
			get => Settings.Default.InsertMethod == c_insertTop;
			set
			{
				Settings.Default.InsertMethod = c_insertTop;
				InsertMethodChanged();
			}
		}

		public bool InsertBottom
		{
			get => Settings.Default.InsertMethod == c_insertBottom;
			set
			{
				Settings.Default.InsertMethod = c_insertBottom;
				InsertMethodChanged();
			}
		}

		public bool SortByID
		{
			get => Settings.Default.SortMethod == c_sortByID;
			set
			{
				Settings.Default.SortMethod = c_sortByID;
				SortMethodChanged();
			}
		}

		public bool SortByName
		{
			get => Settings.Default.SortMethod == c_sortByName;
			set
			{
				Settings.Default.SortMethod = c_sortByName;
				SortMethodChanged();
			}
		}

		public bool FilterContains
		{
			get => Settings.Default.FilterMethod == c_filterContains;
			set
			{
				Settings.Default.FilterMethod = c_filterContains;
				FilterMethodChanged();
			}
		}

		public bool FilterWhole
		{
			get => Settings.Default.FilterMethod == c_filterWhole;
			set
			{
				Settings.Default.FilterMethod = c_filterWhole;
				FilterMethodChanged();
			}
		}

		public bool FilterHide
		{
			get => Settings.Default.FilterMethod == c_filterHide;
			set
			{
				Settings.Default.FilterMethod = c_filterHide;
				FilterMethodChanged();
			}
		}


		private void InsertMethodChanged()
		{
			Settings.Default.Save();
			RaisePropertyChanged(nameof(InsertTop));
			RaisePropertyChanged(nameof(InsertBottom));
		}

		private void SortMethodChanged()
		{
			Settings.Default.Save();
			RaisePropertyChanged(nameof(SortByID));
			RaisePropertyChanged(nameof(SortByName));
			Sort();
		}

		private void FilterMethodChanged()
		{
			Settings.Default.Save();
			RaisePropertyChanged(nameof(FilterContains));
			RaisePropertyChanged(nameof(FilterWhole));
			RaisePropertyChanged(nameof(FilterHide));
			Refresh();
		}
	}
}
