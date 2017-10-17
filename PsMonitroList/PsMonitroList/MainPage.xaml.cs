using PsMonitroList.Model;
using PsMonitroList.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PsMonitroList
{
    public partial class MainPage : ContentPage
    {
        List<RecordBean> lista = new List<RecordBean>();
        public MainPage()
        {
            InitializeComponent();
            riempimento();


        }
        public async static Task<List<RecordBean>> RisultatoConnessione()
        {

            Connessioni<RecordBean> connessioni = new Connessioni<RecordBean>();

            var listaUno = await connessioni.GetJson(URLcs.URLConnessione);
            return listaUno;

        }
        public async void riempimento()
        {
            GrigliaNominativi = await CreazioneGrigliaNominativi.GrigliaNominativi();

        }
     
    }
}
