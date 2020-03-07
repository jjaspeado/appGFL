using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;
using Android.Content.PM;
using Uri = Android.Net.Uri;
using Android.Media.TV;
using AlertDialog = Android.App.AlertDialog;
using Android.Views;
using Android.Text;

namespace purificadoras
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        //protected override void OnCreate(Bundle savedInstanceState)
        //{
        //  base.OnCreate(savedInstanceState);
        // Set our view from the "main" layout resource
        //SetContentView(Resource.Layout.activity_main);
        //}

        Button m20;
        Button m10;
        Button avis;
        Button enviar;
        Button masG;
        Button menG;
        Button masE;
        Button menE;
        Button masB;
        Button menB;
        Button masC;
        Button menC;
        Button masEp;
        Button menEp;
        Button masO;
        Button menO;
        Button masGd;
        Button menGd;
        Button masEd;
        Button menEd;
        Button masBd;
        Button menBd;
        Button masCd;
        Button menCd;
        Button masEpd;
        Button menEpd;
        Button masOd;
        Button menOd;
        TextView preciom20;
        ImageView logog;
        TextView Goforlife;
        EditText gGoforlife;
        ImageView logoE;
        TextView Electropura;
        EditText gElectropura;
        ImageView logob;
        TextView Bonafont;
        EditText gBonafont;
        ImageView logoc;
        TextView Ciel;
        EditText gCiel;
        ImageView logoep;
        TextView Epura;
        EditText gEpura;
        ImageView logoo;
        TextView Otrotipo;
        EditText gOtrotipo;

        TextView preciom10;
        ImageView logogd;
        TextView Goforlifed;
        EditText gGoforlifed;
        ImageView logoEd;
        TextView Electropurad;
        EditText gElectropurad;
        ImageView logobd;
        TextView Bonafontd;
        EditText gBonafontd;
        ImageView logocd;
        TextView Cield;
        EditText gCield;
        ImageView logoepd;
        TextView Epurad;
        EditText gEpurad;
        ImageView logood;
        TextView Otrotipod;
        EditText gOtrotipod;

        EditText edittext;
        EditText direccion;


        int a = 0;
        int b = 0;
        int precio = 16;
        int precio10 = 10;
        int Total;
        int costo;
        int costo10;

        int Go;
        int elec;
        int bona;
        int Cie;
        int epu;
        int Otr;
        int God;
        int elecd;
        int bonad;
        int Cied;
        int epud;
        int Otrd;

        string whatsapp = "com.whatsapp";

        bool VerificarApp(String uri)
        {
            try
            {
                ApplicationContext.PackageManager.GetPackageInfo(uri, PackageInfoFlags.Activities);
                return true;
            }
            catch (PackageManager.NameNotFoundException e)
            {
                return false;
            }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_main);

            preciom20 = FindViewById<TextView>(Resource.Id.preciom20);
            logog = FindViewById<ImageView>(Resource.Id.logog);
            Goforlife = FindViewById<TextView>(Resource.Id.Goforlife);
            masG = FindViewById<Button>(Resource.Id.masG);
            menG = FindViewById<Button>(Resource.Id.menG);
            gGoforlife = FindViewById<EditText>(Resource.Id.gGoforlife);
            
            logoE = FindViewById<ImageView>(Resource.Id.logoE);
            Electropura = FindViewById<TextView>(Resource.Id.Electropura);
            masE = FindViewById<Button>(Resource.Id.masE);
            menE = FindViewById<Button>(Resource.Id.menE);
            gElectropura = FindViewById<EditText>(Resource.Id.gElectropura);
            logob = FindViewById<ImageView>(Resource.Id.logob);
            Bonafont = FindViewById<TextView>(Resource.Id.Bonafont);
            masB = FindViewById<Button>(Resource.Id.masB);
            menB = FindViewById<Button>(Resource.Id.menB);
            gBonafont = FindViewById<EditText>(Resource.Id.gBonafont);
            logoc = FindViewById<ImageView>(Resource.Id.logoc);
            Ciel = FindViewById<TextView>(Resource.Id.Ciel);
            masC = FindViewById<Button>(Resource.Id.masC);
            menC = FindViewById<Button>(Resource.Id.menC);
            gCiel = FindViewById<EditText>(Resource.Id.gCiel);
            logoep = FindViewById<ImageView>(Resource.Id.logoep);
            Epura = FindViewById<TextView>(Resource.Id.Epura);
            masEp = FindViewById<Button>(Resource.Id.masEp);
            menEp = FindViewById<Button>(Resource.Id.menEp);
            gEpura = FindViewById<EditText>(Resource.Id.gEpura);
            logoo = FindViewById<ImageView>(Resource.Id.logoo);
            Otrotipo = FindViewById<TextView>(Resource.Id.Otrotipo);
            masO = FindViewById<Button>(Resource.Id.masO);
            menO = FindViewById<Button>(Resource.Id.menO);
            gOtrotipo = FindViewById<EditText>(Resource.Id.gOtro);

            preciom10 = FindViewById<TextView>(Resource.Id.preciom10);
            logogd = FindViewById<ImageView>(Resource.Id.logogd);
            Goforlifed = FindViewById<TextView>(Resource.Id.Goforlifed);
            masGd = FindViewById<Button>(Resource.Id.masGd);
            menGd = FindViewById<Button>(Resource.Id.menGd);
            gGoforlifed = FindViewById<EditText>(Resource.Id.gGoforlifed);
            logoEd = FindViewById<ImageView>(Resource.Id.logoed);
            Electropurad = FindViewById<TextView>(Resource.Id.Electropurad);
            masEd = FindViewById<Button>(Resource.Id.masEd);
            menEd = FindViewById<Button>(Resource.Id.menEd);
            gElectropurad = FindViewById<EditText>(Resource.Id.gElectropurad);
            logobd = FindViewById<ImageView>(Resource.Id.logobd);
            Bonafontd = FindViewById<TextView>(Resource.Id.Bonafontd);
            masBd = FindViewById<Button>(Resource.Id.masBd);
            menBd = FindViewById<Button>(Resource.Id.menBd);
            gBonafontd = FindViewById<EditText>(Resource.Id.gBonafontd);
            logocd = FindViewById<ImageView>(Resource.Id.logocd);
            Cield = FindViewById<TextView>(Resource.Id.Cield);
            masCd = FindViewById<Button>(Resource.Id.masCd);
            menCd = FindViewById<Button>(Resource.Id.menCd);
            gCield = FindViewById<EditText>(Resource.Id.gCield);
            logoepd = FindViewById<ImageView>(Resource.Id.logoepd);
            Epurad = FindViewById<TextView>(Resource.Id.Epurad);
            masEpd = FindViewById<Button>(Resource.Id.masEpd);
            menEpd = FindViewById<Button>(Resource.Id.menEpd);
            gEpurad = FindViewById<EditText>(Resource.Id.gEpurad);
            logood = FindViewById<ImageView>(Resource.Id.logood);
            Otrotipod = FindViewById<TextView>(Resource.Id.Otrotipod);
            masOd = FindViewById<Button>(Resource.Id.masOd);
            menOd = FindViewById<Button>(Resource.Id.menOd);
            gOtrotipod = FindViewById<EditText>(Resource.Id.gOtrod);
            enviar = FindViewById<Button>(Resource.Id.Enviar);
            edittext = FindViewById<EditText>(Resource.Id.edittext);
            direccion = FindViewById<EditText>(Resource.Id.direccion);

            m20 = FindViewById<Button>(Resource.Id.m20);
            m10 = FindViewById<Button>(Resource.Id.m10);
            avis = FindViewById<Button>(Resource.Id.avis);
            //edtMensaje = FindViewById<edittext>(Resource.Id.edtMensaje);
            enviar.Click += BtnEnviar_Click;
            m20.Click += BtnM20;
            m10.Click += BtnM10;
            avis.Click += Btnavis;
            masG.Click += BtnmasG;
            menG.Click += BtnmenG;
            masE.Click += BtnmasE;
            menE.Click += BtnmenE;
            masB.Click += BtnmasB;
            menB.Click += BtnmenB;
            masC.Click += BtnmasC;
            menC.Click += BtnmenC;
            masEp.Click += BtnmasEp;
            menEp.Click += BtnmenEp;
            masO.Click += BtnmasO;
            menO.Click += BtnmenO;

            masGd.Click += BtnmasGd;
            menGd.Click += BtnmenGd;
            masEd.Click += BtnmasEd;
            menEd.Click += BtnmenEd;
            masBd.Click += BtnmasBd;
            menBd.Click += BtnmenBd;
            masCd.Click += BtnmasCd;
            menCd.Click += BtnmenCd;
            masEpd.Click += BtnmasEpd;
            menEpd.Click += BtnmenEpd;
            masOd.Click += BtnmasOd;
            menOd.Click += BtnmenOd;
        }
        private void BtnmenOd(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gOtrotipod.Text) || gOtrotipod.Text == "0")
            {

            }
            else
            {
                int sum = Convert.ToInt32(gOtrotipod.Text) - 1;
                gOtrotipod.Text = Convert.ToString(sum);
            }
        }

        private void BtnmasOd(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gOtrotipod.Text))
            {
                int sum = 1;
                gOtrotipod.Text = Convert.ToString(sum);
            }
            else
            {
                int sum = Convert.ToInt32(gOtrotipod.Text) + 1;
                gOtrotipod.Text = Convert.ToString(sum);
            }
        }
        private void BtnmenEpd(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gEpurad.Text) || gEpurad.Text == "0")
            {

            }
            else
            {
                int sum = Convert.ToInt32(gEpurad.Text) - 1;
                gEpurad.Text = Convert.ToString(sum);
            }
        }

        private void BtnmasEpd(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gEpurad.Text))
            {
                int sum = 1;
                gEpurad.Text = Convert.ToString(sum);
            }
            else
            {
                int sum = Convert.ToInt32(gEpurad.Text) + 1;
                gEpurad.Text = Convert.ToString(sum);
            }
        }

        private void BtnmasCd(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gCield.Text))
            {
                int sum = 1;
                gCield.Text = Convert.ToString(sum);
            }
            else
            {
                int sum = Convert.ToInt32(gCield.Text) + 1;
                gCield.Text = Convert.ToString(sum);
            }
        }

        private void BtnmenCd(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gCield.Text) || gCield.Text == "0")
            {

            }
            else
            {
                int sum = Convert.ToInt32(gCield.Text) - 1;
                gCield.Text = Convert.ToString(sum);
            }
        }

        private void BtnmenBd(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gBonafontd.Text) || gBonafontd.Text == "0")
            {

            }
            else
            {
                int sum = Convert.ToInt32(gBonafontd.Text) - 1;
                gBonafontd.Text = Convert.ToString(sum);
            }
        }

        private void BtnmasBd(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gBonafontd.Text))
            {
                int sum = 1;
                gBonafontd.Text = Convert.ToString(sum);
            }
            else
            {
                int sum = Convert.ToInt32(gBonafontd.Text) + 1;
                gBonafontd.Text = Convert.ToString(sum);
            }
        }

        private void BtnmasEd(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gElectropurad.Text))
            {
                int sum = 1;
                gElectropurad.Text = Convert.ToString(sum);
            }
            else
            {
                int sum = Convert.ToInt32(gElectropurad.Text) + 1;
                gElectropurad.Text = Convert.ToString(sum);
            }
        }

        private void BtnmenEd(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gElectropurad.Text) || gElectropurad.Text == "0")
            {

            }
            else
            {
                int sum = Convert.ToInt32(gElectropurad.Text) - 1;
                gElectropurad.Text = Convert.ToString(sum);
            }
        }

        private void BtnmenGd(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gGoforlifed.Text) || gGoforlifed.Text == "0")
            {

            }
            else
            {
                int sum = Convert.ToInt32(gGoforlifed.Text) - 1;
                gGoforlifed.Text = Convert.ToString(sum);
            }
        }

        private void BtnmasGd(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gGoforlifed.Text))
            {
                int sum = 1;
                gGoforlifed.Text = Convert.ToString(sum);
            }
            else
            {
                int sum = Convert.ToInt32(gGoforlifed.Text) + 1;
                gGoforlifed.Text = Convert.ToString(sum);
            }
        }





        private void BtnmenO(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gOtrotipo.Text) || gOtrotipo.Text == "0")
            {

            }
            else
            {
                int sum = Convert.ToInt32(gOtrotipo.Text) - 1;
                gOtrotipo.Text = Convert.ToString(sum);
            }
        }

        private void BtnmasO(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gOtrotipo.Text))
            {
                int sum = 1;
                gOtrotipo.Text = Convert.ToString(sum);
            }
            else
            {
                int sum = Convert.ToInt32(gOtrotipo.Text) + 1;
                gOtrotipo.Text = Convert.ToString(sum);
            }
        }
        private void BtnmenEp(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gEpura.Text) || gEpura.Text == "0")
            {

            }
            else
            {
                int sum = Convert.ToInt32(gEpura.Text) - 1;
                gEpura.Text = Convert.ToString(sum);
            }
        }

        private void BtnmasEp(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gEpura.Text))
            {
                int sum = 1;
                gEpura.Text = Convert.ToString(sum);
            }
            else
            {
                int sum = Convert.ToInt32(gEpura.Text) + 1;
                gEpura.Text = Convert.ToString(sum);
            }
        }

        private void BtnmasC(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gCiel.Text))
            {
                int sum = 1;
                gCiel.Text = Convert.ToString(sum);
            }
            else
            {
                int sum = Convert.ToInt32(gCiel.Text) + 1;
                gCiel.Text = Convert.ToString(sum);
            }
        }

        private void BtnmenC(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gCiel.Text) || gCiel.Text == "0")
            {

            }
            else
            {
                int sum = Convert.ToInt32(gCiel.Text) - 1;
                gCiel.Text = Convert.ToString(sum);
            }
        }

        private void BtnmenB(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gBonafont.Text) || gBonafont.Text == "0")
            {

            }
            else
            {
                int sum = Convert.ToInt32(gBonafont.Text) - 1;
                gBonafont.Text = Convert.ToString(sum);
            }
        }

        private void BtnmasB(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gBonafont.Text))
            {
                int sum = 1;
                gBonafont.Text = Convert.ToString(sum);
            }
            else
            {
                int sum = Convert.ToInt32(gBonafont.Text) + 1;
                gBonafont.Text = Convert.ToString(sum);
            }
        }

        private void BtnmasE(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gElectropura.Text))
            {
                int sum = 1;
                gElectropura.Text = Convert.ToString(sum);
            }
            else
            {
                int sum = Convert.ToInt32(gElectropura.Text) + 1;
                gElectropura.Text = Convert.ToString(sum);
            }
        }

        private void BtnmenE(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gElectropura.Text) || gElectropura.Text == "0")
            {

            }
            else
            {
                int sum = Convert.ToInt32(gElectropura.Text) - 1;
                gElectropura.Text = Convert.ToString(sum);
            }
        }

        private void BtnmenG(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gGoforlife.Text) || gGoforlife.Text == "0")
            {

            }
            else
            {
                int sum = Convert.ToInt32(gGoforlife.Text) - 1;
                gGoforlife.Text = Convert.ToString(sum);
            }
        }

        private void BtnmasG(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gGoforlife.Text))
            {
                int sum = 1;
                gGoforlife.Text = Convert.ToString(sum);
            }
            else
            {
                int sum = Convert.ToInt32(gGoforlife.Text) + 1;
                gGoforlife.Text = Convert.ToString(sum);
            }
        }

        private void Btnavis(object sender, EventArgs e)
        {
            string aviso = "Con fundamento en la Ley Federal de Protección de Datos Personales en Posesión de Particulares hacemos de su conocimiento" +
                " que GO FOR LIFE MÉXICO / JULIO CESAR MAGALLANES DEL ANGEL con domicilio Calle 3 Manzana 4 Lote 5, Col. Jorge Jiménez Cantú, Estado" +
                " de México, C.P. 56589, es responsable de recabar sus datos personales, del uso que se le dé a los mismos y de su protección. " +
                "Sus datos personales incluso los sensibles, patrimoniales o financieros que usted proporcione en el Contrato del Servicio o en " +
                "cualquier otro documento o medio físico o electrónico, serán utilizados únicamente con motivo de la operación que nos relaciona y " +
                "se tratarán para todos los fines vinculados con dicha relación, tales como: proveer los servicios que ha solicitado; notificarle" +
                " sobre nuevos servicios o productos que tengan relación con los ya contratados o adquiridos; comunicarle sobre cambios en los mismos;" +
                " realizar evaluaciones periódicas de nuestros servicios a efecto de mejorar la calidad de los mismos; evaluar la calidad del servicio" +
                " que brindamos, y en general, para dar cumplimiento a las obligaciones que hemos contraído con usted. Es importante informarle que " +
                "usted tiene derecho al Acceso, Rectificación y Cancelación de sus datos personales, a Oponerse al tratamiento de los mismos o a " +
                "revocar el consentimiento que para dicho fin nos haya otorgado.Para ello, es necesario que envíe la solicitud, en los términos que " +
                "marca la Ley en su Art. 29, a nuestra Área Administrativa, ubicada en las instalaciones de la Empresa: Paseo de los Volcanes Manzana" +
                " 66 Lote 474, Col.San Buenaventura, Ixtapaluca, Estado de México, C.P. 56536, o bien, vía correo electrónico a info@gflmex.com, el " +
                "cual solicitamos confirme vía telefónica para garantizar su correcta recepción; El responsable dará respuesta de acuerdo a lo " +
                "establecido en el Art. 32 aplicándose las restricciones establecidas en el Art. 34. Por otra parte, hacemos de su conocimiento que " +
                "sus datos seguirán siendo utilizados mientras usted decida seguir con el servicio contratado; con el objetivo general de cumplir con" +
                " las finalidades para las cuales ha proporcionado sus datos, y de acuerdo a lo establecido en el Art.37.En caso de que no obtengamos" +
                " su oposición expresa para que sus datos personales sean transferidos en la forma y términos antes descrita, entenderemos que ha " +
                "otorgado su consentimiento en forma tácita para ello. En caso de que no esté en de acuerdo con el presente aviso de privacidad y de" +
                " que no desee recibir mensajes de nuestra parte, puede enviarnos su solicitud por medio de la dirección electrónica: info @gflmex.com. " +
                "El presente aviso así como sus modificaciones estarán a su disposición en la página de internet http://www.goforlifemexico.com";

            AlertDialog.Builder av = new AlertDialog.Builder(this);
            av.SetMessage(aviso);
            av.SetTitle("AVISO DE PRIVACIDAD ");
            av.SetPositiveButton("Aceptar", PositiveButton);

            AlertDialog dialog = av.Create();
            dialog.Show();
        }

        private void BtnM10(object sender, EventArgs e)
        {
            if (b == 0)
            {
                preciom10.Visibility = ViewStates.Visible;
                logogd.Visibility = ViewStates.Visible;
                Goforlifed.Visibility = ViewStates.Visible;
                masGd.Visibility = ViewStates.Visible;
                menGd.Visibility = ViewStates.Visible;
                gGoforlifed.Visibility = ViewStates.Visible;
                logoEd.Visibility = ViewStates.Visible;
                Electropurad.Visibility = ViewStates.Visible;
                masEd.Visibility = ViewStates.Visible;
                menEd.Visibility = ViewStates.Visible;
                gElectropurad.Visibility = ViewStates.Visible;
                logobd.Visibility = ViewStates.Visible;
                Bonafontd.Visibility = ViewStates.Visible;
                masBd.Visibility = ViewStates.Visible;
                menBd.Visibility = ViewStates.Visible;
                gBonafontd.Visibility = ViewStates.Visible;
                logocd.Visibility = ViewStates.Visible;
                Cield.Visibility = ViewStates.Visible;
                masCd.Visibility = ViewStates.Visible;
                menCd.Visibility = ViewStates.Visible;
                gCield.Visibility = ViewStates.Visible;
                logoepd.Visibility = ViewStates.Visible;
                Epurad.Visibility = ViewStates.Visible;
                masEpd.Visibility = ViewStates.Visible;
                menEpd.Visibility = ViewStates.Visible;
                gEpurad.Visibility = ViewStates.Visible;
                logood.Visibility = ViewStates.Visible;
                Otrotipod.Visibility = ViewStates.Visible;
                masOd.Visibility = ViewStates.Visible;
                menOd.Visibility = ViewStates.Visible;
                gOtrotipod.Visibility = ViewStates.Visible;
                b = 1;
            }
            else
            {
                preciom10.Visibility = ViewStates.Gone;
                logogd.Visibility = ViewStates.Gone;
                Goforlifed.Visibility = ViewStates.Gone;
                masGd.Visibility = ViewStates.Gone;
                menGd.Visibility = ViewStates.Gone;
                gGoforlifed.Visibility = ViewStates.Gone;
                logoEd.Visibility = ViewStates.Gone;
                Electropurad.Visibility = ViewStates.Gone;
                masEd.Visibility = ViewStates.Gone;
                menEd.Visibility = ViewStates.Gone;
                gElectropurad.Visibility = ViewStates.Gone;
                logobd.Visibility = ViewStates.Gone;
                Bonafontd.Visibility = ViewStates.Gone;
                masBd.Visibility = ViewStates.Gone;
                menBd.Visibility = ViewStates.Gone;
                gBonafontd.Visibility = ViewStates.Gone;
                logocd.Visibility = ViewStates.Gone;
                Cield.Visibility = ViewStates.Gone;
                masCd.Visibility = ViewStates.Gone;
                menCd.Visibility = ViewStates.Gone;
                gCield.Visibility = ViewStates.Gone;
                logoepd.Visibility = ViewStates.Gone;
                Epurad.Visibility = ViewStates.Gone;
                masEpd.Visibility = ViewStates.Gone;
                menEpd.Visibility = ViewStates.Gone;
                gEpurad.Visibility = ViewStates.Gone;
                logood.Visibility = ViewStates.Gone;
                Otrotipod.Visibility = ViewStates.Gone;
                masOd.Visibility = ViewStates.Gone;
                menOd.Visibility = ViewStates.Gone;
                gOtrotipod.Visibility = ViewStates.Gone;
                b = 0;
            }
        }

        private void BtnM20(object sender, System.EventArgs e)
        {
            if (a == 0)
            {
                preciom20.Visibility = ViewStates.Visible;
                logog.Visibility = ViewStates.Visible;
                Goforlife.Visibility = ViewStates.Visible;
                masG.Visibility = ViewStates.Visible;
                menG.Visibility = ViewStates.Visible;
                gGoforlife.Visibility = ViewStates.Visible;
                logoE.Visibility = ViewStates.Visible;
                Electropura.Visibility = ViewStates.Visible;
                masE.Visibility = ViewStates.Visible;
                menE.Visibility = ViewStates.Visible;
                gElectropura.Visibility = ViewStates.Visible;
                logob.Visibility = ViewStates.Visible;
                Bonafont.Visibility = ViewStates.Visible;
                masB.Visibility = ViewStates.Visible;
                menB.Visibility = ViewStates.Visible;
                gBonafont.Visibility = ViewStates.Visible;
                logoc.Visibility = ViewStates.Visible;
                Ciel.Visibility = ViewStates.Visible;
                masC.Visibility = ViewStates.Visible;
                menC.Visibility = ViewStates.Visible;
                gCiel.Visibility = ViewStates.Visible;
                logoep.Visibility = ViewStates.Visible;
                Epura.Visibility = ViewStates.Visible;
                masEp.Visibility = ViewStates.Visible;
                menEp.Visibility = ViewStates.Visible;
                gEpura.Visibility = ViewStates.Visible;
                logoo.Visibility = ViewStates.Visible;
                Otrotipo.Visibility = ViewStates.Visible;
                masO.Visibility = ViewStates.Visible;
                menO.Visibility = ViewStates.Visible;
                gOtrotipo.Visibility = ViewStates.Visible;
                a = 1;
            }
            else
            {
                preciom20.Visibility = ViewStates.Gone;
                logog.Visibility = ViewStates.Gone;
                Goforlife.Visibility = ViewStates.Gone;
                masG.Visibility = ViewStates.Gone;
                menG.Visibility = ViewStates.Gone;
                gGoforlife.Visibility = ViewStates.Gone;
                logoE.Visibility = ViewStates.Gone;
                Electropura.Visibility = ViewStates.Gone;
                masE.Visibility = ViewStates.Gone;
                menE.Visibility = ViewStates.Gone;
                gElectropura.Visibility = ViewStates.Gone;
                logob.Visibility = ViewStates.Gone;
                Bonafont.Visibility = ViewStates.Gone;
                masB.Visibility = ViewStates.Gone;
                menB.Visibility = ViewStates.Gone;
                gBonafont.Visibility = ViewStates.Gone;
                logoc.Visibility = ViewStates.Gone;
                Ciel.Visibility = ViewStates.Gone;
                masC.Visibility = ViewStates.Gone;
                menC.Visibility = ViewStates.Gone;
                gCiel.Visibility = ViewStates.Gone;
                logoep.Visibility = ViewStates.Gone;
                Epura.Visibility = ViewStates.Gone;
                masEp.Visibility = ViewStates.Gone;
                menEp.Visibility = ViewStates.Gone;
                gEpura.Visibility = ViewStates.Gone;
                logoo.Visibility = ViewStates.Gone;
                Otrotipo.Visibility = ViewStates.Gone;
                masO.Visibility = ViewStates.Gone;
                menO.Visibility = ViewStates.Gone;
                gOtrotipo.Visibility = ViewStates.Gone;
                a = 0;
            }
        }



        private void BtnEnviar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(edittext.Text) || string.IsNullOrEmpty(direccion.Text))
            {
                AlertDialog.Builder builder = new AlertDialog.Builder(this);
                builder.SetMessage("Debe de colocar el nombre del cliente o su dirección");
                builder.SetTitle("ERROR CAMPOS VACÍOS");
                builder.SetPositiveButton("Aceptar", PositiveButton);

                AlertDialog dialog = builder.Create();
                dialog.Show();
            }
            else if (string.IsNullOrEmpty(gGoforlifed.Text) && string.IsNullOrEmpty(gGoforlife.Text) && string.IsNullOrEmpty(gElectropura.Text) && string.IsNullOrEmpty(gBonafont.Text) && string.IsNullOrEmpty(gCiel.Text) && string.IsNullOrEmpty(gEpura.Text) && string.IsNullOrEmpty(gOtrotipo.Text) && string.IsNullOrEmpty(gElectropurad.Text) && string.IsNullOrEmpty(gBonafontd.Text) && string.IsNullOrEmpty(gCield.Text) && string.IsNullOrEmpty(gEpura.Text) && string.IsNullOrEmpty(gOtrotipod.Text))
            {
                AlertDialog.Builder builder = new AlertDialog.Builder(this);
                builder.SetMessage("Debe de introducir una cantidad para el pedido de los garrafones.");
                builder.SetTitle("ERROR CAMPOS VACÍOS");
                builder.SetPositiveButton("Aceptar", PositiveButton);

                AlertDialog dialog = builder.Create();
                dialog.Show();
            }
            else
            {

                if (string.IsNullOrEmpty(gElectropura.Text))
                {
                    elec = 0;
                }
                else
                {
                    elec = Convert.ToInt32(gElectropura.Text);
                }

                if (string.IsNullOrEmpty(gBonafont.Text))
                {
                    bona = 0;
                }
                else
                {
                    bona = Convert.ToInt32(gBonafont.Text);
                }
                if (string.IsNullOrEmpty(gCiel.Text))
                {
                    Cie = 0;
                }
                else
                {
                    Cie = Convert.ToInt32(gCiel.Text);
                }
                if (string.IsNullOrEmpty(gEpura.Text))
                {
                    epu = 0;
                }
                else
                {
                    epu = Convert.ToInt32(gEpura.Text);
                }
                if (string.IsNullOrEmpty(gOtrotipo.Text))
                {
                    Otr = 0;
                }
                else
                {
                    Otr = Convert.ToInt32(gOtrotipo.Text);
                }
                if (string.IsNullOrEmpty(gGoforlife.Text))
                {
                    Go = 0;
                }
                else
                {
                    Go = Convert.ToInt32(gGoforlife.Text);
                }

                if (string.IsNullOrEmpty(gElectropurad.Text))
                {
                    elecd = 0;
                }
                else
                {
                    elecd = Convert.ToInt32(gElectropurad.Text);
                }

                if (string.IsNullOrEmpty(gBonafontd.Text))
                {
                    bonad = 0;
                }
                else
                {
                    bonad = Convert.ToInt32(gBonafontd.Text);
                }
                if (string.IsNullOrEmpty(gCield.Text))
                {
                    Cied = 0;
                }
                else
                {
                    Cied = Convert.ToInt32(gCield.Text);
                }
                if (string.IsNullOrEmpty(gEpurad.Text))
                {
                    epud = 0;
                }
                else
                {
                    epud = Convert.ToInt32(gEpurad.Text);
                }
                if (string.IsNullOrEmpty(gOtrotipod.Text))
                {
                    Otrd = 0;
                }
                else
                {
                    Otrd = Convert.ToInt32(gOtrotipod.Text);
                }
                if (string.IsNullOrEmpty(gGoforlifed.Text))
                {
                    God = 0;
                }
                else
                {
                    God = Convert.ToInt32(gGoforlifed.Text);
                }
                costo = (Go + elec + bona + Cie + epu + Otr) * precio;
                costo10 = (God + elecd + bonad + Cied + epud + Otrd) * precio10;

                Total = costo + costo10;

                AlertDialog.Builder confir = new AlertDialog.Builder(this);
                confir.SetTitle("CONFIRMACIÓN DEL PEDIDO");
                confir.SetMessage("El costo del pedido solicitado es de $ " + Total);
                confir.SetPositiveButton("Aceptar", Aceptar);
                confir.SetNegativeButton("Cancelar", Cancelar);

                AlertDialog dialog = confir.Create();
                dialog.Show();


            }
        }

        private void PositiveButton(object sender, DialogClickEventArgs e)
        {
           
        }

        private void Cancelar(object sender, DialogClickEventArgs e)
        {
          
        }

        private void Aceptar(object sender, DialogClickEventArgs e)
        {
            if (VerificarApp(whatsapp))
            {
                string mensaje = "El nombre del cliente es: \n" + edittext.Text + "\n" + "La dirección del cliente es: \n" + direccion.Text +"\n";

                
                if (Go == 0 && elec == 0 && bona == 0 && Cie == 0 && epu == 0 && Otr == 0)
                {

                }
                else
                {
                    mensaje = mensaje + "\n" + "EL NÚMERO DE GARRAFONES DE 19-20 L:\n";
                }
                if (string.IsNullOrEmpty(gGoforlife.Text) || gGoforlife.Text == "0")
                {

                }
                else
                {
                    mensaje = mensaje + "Go for life: " + gGoforlife.Text + "\n";
                }
                if (string.IsNullOrEmpty(gElectropura.Text) || gElectropura.Text == "0")
                {

                }
                else
                {
                    mensaje = mensaje + "Electropura: " + gElectropura.Text + "\n";
                }
                if (string.IsNullOrEmpty(gBonafont.Text) || gBonafont.Text == "0")
                {

                }
                else
                {
                    mensaje = mensaje + "Bonafon: " + gBonafont.Text + "\n";
                }
                if (string.IsNullOrEmpty(gCiel.Text) || gCiel.Text == "0")
                {

                }
                else
                {
                    mensaje = mensaje + "Ciel: " + gCiel.Text + "\n";
                }
                if (string.IsNullOrEmpty(gEpura.Text) || gEpura.Text == "0")
                {

                }
                else
                {
                    mensaje = mensaje + "E Pura: " + gEpura.Text + "\n";
                }
                if (string.IsNullOrEmpty(gOtrotipo.Text) || gOtrotipo.Text == "0")
                {

                }
                else
                {
                    mensaje = mensaje + "De Otro Tipo: " + gOtrotipo.Text + "\n";
                }
                if (God == 0 && elecd == 0 && bonad == 0 && Cied == 0 && epud == 0 && Otrd == 0)
                {

                }
                else
                {
                    mensaje = mensaje + "\n" + "EL NÚMERO DE GARRAFONES DE 10-11 L:\n";
                }
                if (string.IsNullOrEmpty(gGoforlifed.Text) || gGoforlifed.Text == "0")
                {

                }
                else
                {
                    mensaje = mensaje + "Go for life: " + gGoforlifed.Text + "\n";
                }
                if (string.IsNullOrEmpty(gElectropurad.Text) || gElectropurad.Text == "0")
                {

                }
                else
                {
                    mensaje = mensaje + "Electropura: " + gElectropurad.Text + "\n";
                }
                if (string.IsNullOrEmpty(gBonafontd.Text) || gBonafontd.Text == "0")
                {

                }
                else
                {
                    mensaje = mensaje + "Bonafon: " + gBonafontd.Text + "\n";
                }
                if (string.IsNullOrEmpty(gCield.Text) || gCield.Text == "0")
                {

                }
                else
                {
                    mensaje = mensaje + "Ciel: " + gCield.Text + "\n";
                }
                if (string.IsNullOrEmpty(gEpurad.Text) || gEpurad.Text == "0")
                {

                }
                else
                {
                    mensaje = mensaje + "E Pura: " + gEpurad.Text + "\n";
                }
                if (string.IsNullOrEmpty(gOtrotipod.Text) || gOtrotipod.Text == "0")
                {

                }
                else
                {
                    mensaje = mensaje + "De Otro Tipo: " + gOtrotipod.Text + "\n";
                }


                Intent intent = new Intent(Intent.ActionView);
                String uri = "whatsapp://send?phone=" + "52 + 5539679305" + " &text=" + mensaje;
                intent.SetData(Uri.Parse(uri));
                StartActivity(intent);

            }
            else
            {
                Toast.MakeText(this, "WhatsApp no está instalado. No se pudo enviar el mensaje", ToastLength.Long).Show();
            }
        }
    }
}