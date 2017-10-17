using PsMonitroList.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PsMonitroList.Services
{
  public class CreazioneGrigliaNominativi
    {
        public async static  Task<Grid> GrigliaNominativi()
        {
            List<RecordBean> lista = new List<RecordBean>();
            int row = 0;
            int colonna = 0;
            string cognome="";
            string immagine="rettangoloA.png";
            lista = await RisultatoConnessione();

            foreach (var i in lista )
            {
               cognome = i.cognome;
               /* row++;*/
            }
            colonna = 0;

            var grigliaNominativi = new Grid
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            grigliaNominativi.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grigliaNominativi.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var image = new Image
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Source = immagine
            };
            var labelCognome = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = cognome,
                TextColor= Color.Black
            };
            grigliaNominativi.Children.Add(image,row,colonna);
            grigliaNominativi.Children.Add(labelCognome,row,colonna);
         
            return grigliaNominativi;
        }
        public async static Task<List<RecordBean>> RisultatoConnessione()
        {

            Connessioni<RecordBean> connessioni = new Connessioni<RecordBean>();

           var listaUno = await connessioni.GetJson(URLcs.URLConnessione);
            return listaUno;
            
        }
    }
}
