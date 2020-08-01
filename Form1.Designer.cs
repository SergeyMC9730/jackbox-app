using System.Windows.Forms;
using System;
using System.IO;
using DiscordRPC;
using System.Net;
using System.Collections.Generic;

namespace jackboxapp
{
    public class strings
    {
            public static string RussianMQ2CEb = "Моды и Смехлыст 2 Сделай сам (кнопка)";
            public static string RussianChangeLog = "Список изм.";
            public static string RussianBack = "Назад";
            public static string RussianWIPTitle = "ВР";
            public static string RussianWIPText = "В Разработке";
            public static string RussianCheckForUpdates = "Проверить на обновления";
            public static string RussianNewUpdate = "Новый апдейт! Нажмите, чтобы скачать!";
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
            public static string EnglishChangeLog = "Change Log";
            public static string EnglishWIPTitle = "WIP";
            public static string EnglishWIPText = "Work In Progress";
            public static string EnglishCheckForUpdates = "Check for updates";
            public static string EnglishNewUpdate = "New update! Click for download!";
            public static string EnglishBack = "Back";
            public static string EnglishMQ2CEb = "Mods && Quiplash 2 Custom Episodes (button)";
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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.label4.Location = new System.Drawing.Point(592, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "1.3 - added link to GitHub\r\n        added language selector";
            this.label4.Visible = false;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1007, 563);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 32);
            this.button5.TabIndex = 17;
            this.button5.Text = "Change Log";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(1114, 563);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 32);
            this.button6.TabIndex = 18;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(777, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(396, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mods && Quiplash 2 Custom Episodes (button)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // webBrowser2
            // 
            this.webBrowser2.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser2.Location = new System.Drawing.Point(777, 78);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(398, 310);
            this.webBrowser2.TabIndex = 20;
            this.webBrowser2.Url = new System.Uri("http://51.83.129.149/jppv/en", System.UriKind.Absolute);
            this.webBrowser2.Visible = false;
            // 
            // webBrowser3
            // 
            this.webBrowser3.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser3.Location = new System.Drawing.Point(775, 78);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(398, 310);
            this.webBrowser3.TabIndex = 21;
            this.webBrowser3.Url = new System.Uri("http://51.83.129.149/jppv/ru", System.UriKind.Absolute);
            this.webBrowser3.Visible = false;
            this.webBrowser3.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser3_DocumentCompleted_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(781, 484);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "Check for updates";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(937, 484);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(228, 23);
            this.button8.TabIndex = 23;
            this.button8.Text = "New update! Click for download!";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 631);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.webBrowser3);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Jackbox APP (release 1.4 beta 2)";
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
        //public ChromiumWebBrowser chromeBrowser;
        //public browserViewer EO.WebBrowser;
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
        //strings bools = new strings();
        public bool english = true;
        public bool funStarted = false;
        public bool isNewUpdateFounded = false;
        public void checkupdatesbutton()
        {
            //var checkupdates = WebRequest.Create("s") as HttpWebRequest;
            this.button8.Visible = true;
            isNewUpdateFounded = true;
            if(english == true)
            {
                MessageBox.Show(strings.EnglishWIPText, strings.EnglishWIPTitle);
            } else
            {
                MessageBox.Show(strings.RussianWIPText, strings.RussianWIPTitle);
            }


        }
        public void changelogbutton()
        {
            this.button6.Visible = true;  //back button
            this.button5.Visible = false; //change log button
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.label6.Visible = false;
            this.label7.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            this.button7.Visible = false;
            this.button8.Visible = false;
            Console.WriteLine(english);
            if(english == true)
            {
                this.webBrowser2.Visible = true;
            } else
            {
                this.webBrowser3.Visible = true;
            }
        }
        public void changelogbuttonback()
        {
            this.button6.Visible = false; //back button
            this.button5.Visible = true; //change log button
            this.button1.Visible = true;
            this.button2.Visible = true;
            this.label6.Visible = true;
            this.label7.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.button7.Visible = true;
            if(isNewUpdateFounded == true)
            {
                this.button8.Visible = true;
            } else
            {
                this.button8.Visible = false;
            }
            this.webBrowser2.Visible = false;
            this.webBrowser3.Visible = false;
        }
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
            System.Diagnostics.Process.Start("https://github.com/SergeyMC9730/jackbox-app");;
        }
        public void englishLanguage()
        {
            this.label2.Text = strings.EnglishIdeaAuthor;
            this.label3.Text = strings.EnglishProgramAuthor;
            this.label4.Text = strings.EnglishReleaseText;
            this.label7.Text = strings.EnglishMQ2CEb;
            this.button5.Text = strings.EnglishChangeLog;
            this.button6.Text = strings.EnglishBack;
            this.button7.Text = strings.EnglishCheckForUpdates;
            this.button8.Text = strings.EnglishNewUpdate;
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
            this.label7.Text = strings.RussianMQ2CEb;
            this.button5.Text = strings.RussianChangeLog;
            this.button6.Text = strings.RussianBack;
            this.button7.Text = strings.RussianCheckForUpdates;
            this.button8.Text = strings.RussianNewUpdate;
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
        private Button button5;
        private Button button6;
        private Label label7;
        private WebBrowser webBrowser2;
        private WebBrowser webBrowser3;
        private Button button7;
        private Button button8;
    }

    public class strings2
    {
    }
}

