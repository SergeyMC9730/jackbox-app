using System.Windows.Forms;
using System;
//using strings2;
//using Discord;

using DiscordRPC;
namespace jackboxapp
{
    public class strings
    {
            public static string RussianIdeaAuthor = "Автор идеи: Calamity#6480";
            public static string RussianProgramAuthor = "Автор программы: dogotrigger#0355";
            public static string RussianWindowText = "Джекбокс Приложение (релиз 1.3)";
            public static string RussianReleaseButton = "Релизы";
            public static string RussianReleaseText = "1.3 - добавлена ссылка на GitHub\r\n        добавлен выбор языка";
            public static string EnglishIdeaAuthor = "Idea author: Calamity#6480";
            public static string EnglishProgramAuthor = "Programm author: dogotrigger#0355";
            public static string EnglishWindowText = "Jackbox APP (release 1.3)";
            public static string EnglishReleaseButton = "Releases";
            public static string EnglishReleaseText = "1.3 - added link to GitHub\r\n        added language selector";
            public bool english = true;
            public bool funStarted = false;
    }
    partial class Form1
    {
        
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(792, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jackbox APP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(759, 619);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Url = new System.Uri("http://example.com", System.UriKind.Absolute);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(774, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Idea author: Calamity#6480";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(773, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Programm author: dogotrigger#0355";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jackboxapp.Properties.Resources.brwi2;
            this.pictureBox1.Location = new System.Drawing.Point(765, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3, 800);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // button2
            // 
            this.button2.Image = global::jackboxapp.Properties.Resources.englishSmall;
            this.button2.Location = new System.Drawing.Point(774, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(398, 158);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::jackboxapp.Properties.Resources.russianSmall;
            this.button1.Location = new System.Drawing.Point(774, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(398, 157);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1106, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "GitHub";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(875, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 33);
            this.label6.TabIndex = 13;
            this.label6.Text = "Select language";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(781, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "English (английский)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1027, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Russian (русский)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1007, 569);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = strings.EnglishReleaseText;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 631);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Jackbox APP (release 1.3)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public DiscordRpcClient client;
        //client = new DiscordRpcClient("737629176819089418");
       public void Initialize()
        {
            /*
            Create a discord client
            NOTE: 	If you are using Unity3D, you must use the full constructor and define
                     the pipe connection.
            */
            client = new DiscordRpcClient("737629176819089418");

            //Set the logger
            //client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            //Subscribe to events
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };

            //Connect to the RPC
            client.Initialize();

            //Set the rich presence
            //Call this as many times as you want and anywhere in your code.
            client.SetPresence(new RichPresence()
            {
                Details = "Play Jackbox Games within our app!",
                State = "Availiable on GitHub!",
                Assets = new Assets()
                {
                    LargeImageKey = "rpciconbgno",
                    LargeImageText = "Box",
                    SmallImageKey = "tv",
                    SmallImageText = "jackbox.tv"
                }
            });
        }
        //Initialize();
        //var discord = new Discord.Discord("737629176819089418", (UInt64)Discord.CreateFlags.Default);
        //strings bools = new strings();
        public bool english = true;
        public bool funStarted = false;
        public void jackboxRU()
        {
            //bools.funStarted 
            funStarted = true;
            if(english == false)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = "Играй в игры Jackbox через наше приложение!",
                    State = "Доступно на GitHub!",
                    Assets = new Assets()
                    {
                        LargeImageKey = "rpciconbgno",
                        LargeImageText = "Коробка",
                        SmallImageKey = "fun",
                        SmallImageText = "jackbox.fun"
                    }
                });
            } else
            {
                client.SetPresence(new RichPresence()
                {
                    Details = "Play Jackbox Games within our app!",
                    State = "Availiable on GitHub!",
                    Assets = new Assets()
                    {
                        LargeImageKey = "rpciconbgno",
                        LargeImageText = "Box",
                        SmallImageKey = "fun",
                        SmallImageText = "jackbox.fun"
                    }
                });
            }
            webBrowser1.Url = new System.Uri("https://jackbox.fun", System.UriKind.Absolute);
        }
        public void jackboxEN()
        {
            funStarted = false;
            if (english == false)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = "Играй в игры Jackbox через наше приложение!",
                    State = "Доступно на GitHub!",
                    Assets = new Assets()
                    {
                        LargeImageKey = "rpciconbgno",
                        LargeImageText = "Коробка",
                        SmallImageKey = "tv",
                        SmallImageText = "jackbox.tv"
                    }
                });
            }
            else
            {
                client.SetPresence(new RichPresence()
                {
                    Details = "Play Jackbox Games within our app!",
                    State = "Availiable on GitHub!",
                    Assets = new Assets()
                    {
                        LargeImageKey = "rpciconbgno",
                        LargeImageText = "Box",
                        SmallImageKey = "tv",
                        SmallImageText = "jackbox.tv"
                    }
                });
            }
            webBrowser1.Url = new System.Uri("https://jackbox.tv", System.UriKind.Absolute);
        }
        public void github()
        {
            webBrowser1.Url = new System.Uri("https://github.com/SergeyMC9730/jackbox-app", System.UriKind.Absolute);
        }
        public void englishLanguage()
        {
            this.label2.Text = strings.EnglishIdeaAuthor;
            this.label3.Text = strings.EnglishProgramAuthor;
            this.label4.Text = strings.EnglishReleaseText;
            this.Text = strings.EnglishWindowText;
            //strings.russian = false;
            english = true;
            if(funStarted == true)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = "Play Jackbox Games within our app!",
                    State = "Availiable on GitHub!",
                    Assets = new Assets()
                    {
                        LargeImageKey = "rpciconbgno",
                        LargeImageText = "Box",
                        SmallImageKey = "fun",
                        SmallImageText = "jackbox.fun"
                    }
                });
            } else
            {
                client.SetPresence(new RichPresence()
                {
                    Details = "Play Jackbox Games within our app!",
                    State = "Availiable on GitHub!",
                    Assets = new Assets()
                    {
                        LargeImageKey = "rpciconbgno",
                        LargeImageText = "Box",
                        SmallImageKey = "tv",
                        SmallImageText = "jackbox.tv"
                    }
                });
            }
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        public void russianLanguage()
        {
            this.label2.Text = strings.RussianIdeaAuthor;
            this.label3.Text = strings.RussianProgramAuthor;
            this.label4.Text = strings.RussianReleaseText;
            this.Text = strings.EnglishWindowText;
            //strings.russian = false;
            english = false;
            if (funStarted == true)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = "Играй в игры Jackbox через наше приложение!",
                    State = "Доступно на GitHub!",
                    Assets = new Assets()
                    {
                        LargeImageKey = "rpciconbgno",
                        LargeImageText = "Коробка",
                        SmallImageKey = "fun",
                        SmallImageText = "jackbox.fun"
                    }
                });
            }
            else
            {
                client.SetPresence(new RichPresence()
                {
                    Details = "Играй в игры Jackbox через наше приложение!",
                    State = "Доступно на GitHub!",
                    Assets = new Assets()
                    {
                        LargeImageKey = "rpciconbgno",
                        LargeImageText = "Коробка",
                        SmallImageKey = "tv",
                        SmallImageText = "jackbox.tv"
                    }
                });
            }
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Button button3;
        private Button button4;
        private Label label4;
    }

    public class strings2
    {
    }
}

