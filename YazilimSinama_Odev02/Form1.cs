using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinama_Odev02
{
    public partial class Form1 : Form
    {
        public class yer
        {
            public int x { get; set; }
            public int y { get; set; }
            public int visitCount { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }
        int[] tasx = new int[7];
        int[] tasy = new int[7];
        int tassayisi, bulunansayac, toplamadimsayisi;
        string secili = "";
        bool tasyok = true;
        bool finishyok = true;
        bool[] bulundu = new bool[7];
        private int adimsayisi;

        public int adimSayisi
        {
            get { return adimsayisi; }
            set
            {
                adimsayisi = value;
                txtAdimSayisi.Text = adimsayisi.ToString();
                txtAdimSayisi.Refresh();
            }
        }

        void IlkDegerlereCek()
        {
            for (int i = 0; i < 7; i++)
            {
                tasx[i] = 0;
                tasy[i] = 0;
                bulundu[i] = false;
            }

            tassayisi = 0;
            bulunansayac = 0;
            tasyok = true;
            finishyok = true;
            adimSayisi = 0;
            toplamadimsayisi = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pctCheese.Image.Tag = "finish";
            pctMouse.Image.Tag = "tas";
            pctWall.Image.Tag = "duvar";
            pctYol.Image.Tag = "yol";

            btnOlustur_Click(null, null);
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            IlkDegerlereCek();
            int buyukluk;
            int.TryParse(txtBuyukluk.Text, out buyukluk);

            dgAlan.Columns.Clear();
            dgAlan.Rows.Clear();

            if (buyukluk > 0)
            {

                for (int i = 0; i < buyukluk; i++)
                {
                    DataGridViewImageColumn asd = new DataGridViewImageColumn();
                    asd.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dgAlan.Columns.Add(asd);

                }
                dgAlan.Rows.Add(buyukluk);
            }

            dgAlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewRow item in dgAlan.Rows)
            {
                item.Height = dgAlan.Columns[0].Width;
            }

            //İlk satıra ve son satıra duvar diz
            if (dgAlan.Rows.Count > 0)
            {
                foreach (DataGridViewImageCell item in dgAlan.Rows[0].Cells)
                {
                    item.Value = pctWall.Image;
                    item.Tag = 0;
                }

                foreach (DataGridViewImageCell item in dgAlan.Rows[dgAlan.Rows.Count - 1].Cells)
                {
                    item.Value = pctWall.Image;
                    item.Tag = 0;
                }
            }

            //İlk sütuna ve son sütuna duvar diz
            for (int i = 0; i < dgAlan.Rows.Count - 1; i++)
            {
                dgAlan[0, i].Value = pctWall.Image;
                dgAlan[0, i].Tag = 0;
                dgAlan[dgAlan.Columns.Count - 1, i].Value = pctWall.Image;
                dgAlan[dgAlan.Columns.Count - 1, i].Tag = 0;
            }
            //Yolları diz
            for (int i = 1; i < dgAlan.Columns.Count - 1; i++)
            {
                for (int j = 1; j < dgAlan.Rows.Count - 1; j++)
                {
                    dgAlan[i, j].Value = pctYol.Image;
                    dgAlan[i, j].Tag = 0;
                }
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            pictureBox4.Image = p.Image;
            secili = p.Name;
        }

        private void btnCoz_Click(object sender, EventArgs e)
        {
            if (finishyok)
            {
                MessageBox.Show("finish eklenmelidir.");
                return;
            }
            if (tasyok)
            {
                MessageBox.Show("Bütün Taşlar Eklenmelidir.");
                return;
            }
            bulundu[0] = false;


            //Overflow exception olduğu için bu kontrol koyuldu. 10 x 10 gridde program hataya düşmesin diye.
            //Bu mesaj veriliyorsa finish ulaşılamayacak bir yere konulmuş olabilir. finishin etrafına duvar dizmek gibi.
            if (adimsayisi > 3500)
            {
                MessageBox.Show("Çok fazla yol gezdik ama finishi bulunamadık. Duvarların içinden geçebilseydik finishi  bulurduk.");
                adimSayisi = 0;
                for (int i = 0; i < dgAlan.ColumnCount; i++)
                {
                    for (int j = 0; j < dgAlan.RowCount; j++)
                    {
                        dgAlan[i, j].Tag = 0;
                    }
                }
                return;
            }

            //Şu anki hücrenin etrafındaki hareket edilebilecek yerler tespit edilir.
            List<yer> git = GidilebilecekYerler();

            //null gelmişse bulunmuştur. 
            //Bulundu durumunda, adim sayisi sıfırlanır.
            //dgAlan[x,y].Tag özelliğinde tuttuğumuz visitCount sıfırlanır.
            if (git == null)
            {
                adimSayisi = 0;
                for (int i = 0; i < dgAlan.ColumnCount; i++)
                {
                    for (int j = 0; j < dgAlan.RowCount; j++)
                    {
                        dgAlan[i, j].Tag = 0;
                    }
                }
                if (bulunansayac == 7)
                {
                    return;
                }
                git = GidilebilecekYerler();
            }

            //Listeden dönen yerler orderby yapılarak en az gidilmiş yöne doğru gidilmesi sağlanır.
            git = git.OrderBy(asd => asd.visitCount).ToList();

            //Bu kontrol ile tasy[0]e hiç hareket alanı verilmezse hata alması engellenir.
            //Örneğin tasnin etrafını duvarla kapatmak.
            if (git.Count == 0)
            {
                MessageBox.Show("Hiç bir yere gidemiyorum");
                return;
            }

            Ilerle(git[0]);
            dgAlan.Refresh();

            if (!bulundu[bulunansayac])
            {
                adimSayisi += 1;
                btnCoz_Click(null, null);
            }

        }
        void Ilerle(yer yy)
        {
            Image tas = (dgAlan[tasx[bulunansayac], tasy[bulunansayac]].Value as Image);
            dgAlan[tasx[bulunansayac], tasy[bulunansayac]].Value = pctYol.Image;
            tasx[bulunansayac] = yy.x;
            tasy[bulunansayac] = yy.y;
            dgAlan[tasx[bulunansayac], tasy[bulunansayac]].Value = tas;
            dgAlan[tasx[bulunansayac], tasy[bulunansayac]].Tag = (int)dgAlan[tasx[bulunansayac], tasy[bulunansayac]].Tag + 1;

        }

        List<yer> GidilebilecekYerler()
        {
            List<yer> ye = new List<yer>();

            #region buldukmu
            //Sol
            if (((dgAlan[tasx[bulunansayac] - 1, tasy[bulunansayac]].Value) as Image)?.Tag.ToString() == "finish")
            {
                toplamadimsayisi += adimSayisi;
                MessageBox.Show(adimSayisi + " adımda bulundu!");
                MessageBox.Show((bulunansayac + 1) + " tane taşın toplam adım sayısı:" + toplamadimsayisi);
                bulundu[bulunansayac] = true;
                Image tas = (dgAlan[tasx[bulunansayac], tasy[bulunansayac]].Value as Image);
                dgAlan[tasx[bulunansayac], tasy[bulunansayac]].Value = pctYol.Image;
                bulunansayac++;
                if (true)
                {
                    return null;
                }
            }
            //Yukarı
            if (((dgAlan[tasx[bulunansayac], tasy[bulunansayac] - 1].Value) as Image)?.Tag.ToString() == "finish")
            {
                toplamadimsayisi += adimSayisi;
                MessageBox.Show(adimSayisi + " adımda bulundu!");
                MessageBox.Show((bulunansayac + 1) + " tane taşın toplam adım sayısı:" + toplamadimsayisi);
                bulundu[bulunansayac] = true;
                Image tas = (dgAlan[tasx[bulunansayac], tasy[bulunansayac]].Value as Image);
                dgAlan[tasx[bulunansayac], tasy[bulunansayac]].Value = pctYol.Image;
                bulunansayac++;
                if (true)
                {
                    return null;
                }
            }
            //Sağ
            if (((dgAlan[tasx[bulunansayac] + 1, tasy[bulunansayac]].Value) as Image)?.Tag.ToString() == "finish")
            {
                toplamadimsayisi += adimSayisi;
                MessageBox.Show(adimSayisi + " adımda bulundu!");
                MessageBox.Show((bulunansayac + 1) + " tane taşın toplam adım sayısı:" + toplamadimsayisi);
                bulundu[bulunansayac] = true;
                Image tas = (dgAlan[tasx[bulunansayac], tasy[bulunansayac]].Value as Image);
                dgAlan[tasx[bulunansayac], tasy[bulunansayac]].Value = pctYol.Image;
                bulunansayac++;
                if (true)
                {
                    return null;
                }
            }
            //Aşağı
            if (((dgAlan[tasx[bulunansayac], tasy[bulunansayac] + 1].Value) as Image)?.Tag.ToString() == "finish")
            {
                toplamadimsayisi += adimSayisi;
                MessageBox.Show(adimSayisi + " adımda bulundu!");
                MessageBox.Show((bulunansayac + 1) + " tane taşın toplam adım sayısı:" + toplamadimsayisi);
                bulundu[bulunansayac] = true;
                Image tas = (dgAlan[tasx[bulunansayac], tasy[bulunansayac]].Value as Image);
                dgAlan[tasx[bulunansayac], tasy[bulunansayac]].Value = pctYol.Image;
                bulunansayac++;
                if (true)
                {
                    return null;
                }
            }
            #endregion

            //Sol
            if (((dgAlan[tasx[bulunansayac] - 1, tasy[bulunansayac]].Value) as Image)?.Tag.ToString() == "yol")
            {
                ye.Add(new yer { x = tasx[bulunansayac] - 1, y = tasy[bulunansayac], visitCount = (int)dgAlan[tasx[bulunansayac] - 1, tasy[bulunansayac]].Tag });
            }
            //Sağ
            if (((dgAlan[tasx[bulunansayac] + 1, tasy[bulunansayac]].Value) as Image)?.Tag.ToString() == "yol")
            {
                ye.Add(new yer { x = tasx[bulunansayac] + 1, y = tasy[bulunansayac], visitCount = (int)dgAlan[tasx[bulunansayac] + 1, tasy[bulunansayac]].Tag });
            }
            //Yukarı
            if (((dgAlan[tasx[bulunansayac], tasy[bulunansayac] - 1].Value) as Image)?.Tag.ToString() == "yol")
            {
                ye.Add(new yer { x = tasx[bulunansayac], y = tasy[bulunansayac] - 1, visitCount = (int)dgAlan[tasx[bulunansayac], tasy[bulunansayac] - 1].Tag });
            }

            //Aşağı
            if (((dgAlan[tasx[bulunansayac], tasy[bulunansayac] + 1].Value) as Image)?.Tag.ToString() == "yol")
            {
                ye.Add(new yer { x = tasx[bulunansayac], y = tasy[bulunansayac] + 1, visitCount = (int)dgAlan[tasx[bulunansayac], tasy[bulunansayac] + 1].Tag });
            }

            return ye;
        }

        private void dgAlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Dış duvarlar silinemesin
            if (e.ColumnIndex == 0 || e.ColumnIndex == dgAlan.ColumnCount - 1 ||
                e.RowIndex == 0 || e.RowIndex == dgAlan.RowCount - 1)
            {
                MessageBox.Show("Dış duvar değiştirilemez.");
                return;
            }

            DataGridViewImageCell cell = dgAlan[e.ColumnIndex, e.RowIndex] as DataGridViewImageCell;

            //Değiştirilecek hücrede tas ya da finish varsa tasyok, finishyok alanları tekrar trueya çekilir
            if (cell.Value != null && (cell.Value as Image).Tag != null)
            {
                if ((cell.Value as Image).Tag.ToString() == "tas")
                {
                    //tasyok = !tasyok;
                    tassayisi--;
                }
                if ((cell.Value as Image).Tag.ToString() == "finish")
                {
                    finishyok = !finishyok;
                }
            }

            switch (secili)
            {
                case "pctWall":
                    cell.Value = pictureBox4.Image;
                    break;
                case "pctYol":
                    cell.Value = pictureBox4.Image;
                    break;
                case "pctCheese":
                    if (finishyok)
                    {
                        //Yoksa ekle
                        cell.Value = pictureBox4.Image;
                        finishyok = !finishyok;
                    }
                    else
                    {
                        MessageBox.Show("En fazla 1 finish eklenebilir.");
                    }
                    break;
                case "pctMouse":
                    if (tasyok)
                    {
                        //Yoksa ekle
                        tasx[tassayisi] = e.ColumnIndex;
                        tasy[tassayisi] = e.RowIndex;
                        cell.Value = pictureBox4.Image;
                        cell.Tag = (int)cell.Tag + 1;
                        tassayisi++;
                        if (tassayisi == 7)
                        {
                            tasyok = !tasyok;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bütün taşlar eklendi.");
                    }
                    break;
                default:
                    break;
            }

        }


    }
}
