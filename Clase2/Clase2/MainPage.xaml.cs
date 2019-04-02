using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace Clase2
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
		
		FileOpenPicker seleccionadorImagen;
		BitmapImage img;
		Windows.Storage.StorageFile archivo;
		Windows.Storage.StorageFolder folder;
		public MainPage()
        {

            this.InitializeComponent();
			seleccionadorImagen = new FileOpenPicker();
			seleccionadorImagen.ViewMode = Windows.Storage.Pickers.PickerViewMode.List;
			seleccionadorImagen.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
			seleccionadorImagen.FileTypeFilter.Add(".jpg");
			
		}



		async public void MButton_Click(object sender, RoutedEventArgs e)
		{
		img = new BitmapImage();
		archivo = await seleccionadorImagen.PickSingleFileAsync();
		IRandomAccessStream fileStream = await archivo.OpenAsync(FileAccessMode.Read);
		
		ListFiles(archivo);
		await img.SetSourceAsync(fileStream);
		MImagen.Source = img;
			MImgDate.Text =$"{archivo.DateCreated.DayOfWeek.ToString()} " +
				$"{ archivo.DateCreated.Day} del { archivo.DateCreated} " +
				$"{ archivo.DateCreated.Year} ";

		}

		 public async void ListFiles(StorageFile ar) {



		}


		
	}
}
