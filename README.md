[![Release](https://img.shields.io/github/v/release/flareoNNN/FontSharp "Release")](https://github.com/flareoNNN/FontSharp/releases "Release")
[![License](https://img.shields.io/github/license/flareoNNN/FontSharp "License")](https://github.com/flareoNNN/FontSharp/blob/master/LICENSE "License")

# FontSharp

C# için yazılmış kısa yoldan font ekleme kütüphanesi.<br>
Versiyon: *1.0.0*

# Kurulum

FontSharp Link: [https://github.com/flareoNNN/FontSharp/releases](https://github.com/flareoNNN/FontSharp/releases)<br><br>

FontSharp'ı visual studio'da projenize girerek references(başvurular) kısmından .dll dosyası olarak ekleyebilirsiniz. Uygulamanıza herhangi bir font eklemek için ise fontun .ttf veya .otf dosyasını resources kısmına atarak aşağıdaki kullanım örneği ile ekleyebilirsiniz.

# Kullanım

````c#
fontSharp.YeniFont(byte[] fontDosya, float fontSize);
````

````c#
using System;
using System.Drawing;
using System.Windows.Forms;
using FontSharp;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Font gotham = fontSharp.YeniFont(Properties.Resources.Gotham_Black_Italic, 20.0F);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = gotham;
        }
    }
}
````

# Lisans

Apache License 2.0