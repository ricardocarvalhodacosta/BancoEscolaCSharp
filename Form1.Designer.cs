namespace Escola
{
    partial class bancoescola
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            matricula = new Label();
            aluno = new Label();
            nota1 = new Label();
            nota2 = new Label();
            media = new Label();
            textMatricula = new TextBox();
            textNome = new TextBox();
            textNota1 = new TextBox();
            textNota2 = new TextBox();
            textMedia = new TextBox();
            gravar = new Button();
            verificar = new Button();
            fechar = new Button();
            sala = new Label();
            textSala = new TextBox();
            SuspendLayout();
            // 
            // matricula
            // 
            matricula.AutoSize = true;
            matricula.Location = new Point(25, 31);
            matricula.Name = "matricula";
            matricula.Size = new Size(77, 15);
            matricula.TabIndex = 0;
            matricula.Text = "Nº Matricula:";
            // 
            // aluno
            // 
            aluno.AutoSize = true;
            aluno.Location = new Point(25, 86);
            aluno.Name = "aluno";
            aluno.Size = new Size(95, 15);
            aluno.TabIndex = 1;
            aluno.Text = "Nome do Aluno:";
            // 
            // nota1
            // 
            nota1.AutoSize = true;
            nota1.Location = new Point(25, 115);
            nota1.Name = "nota1";
            nota1.Size = new Size(83, 15);
            nota1.TabIndex = 2;
            nota1.Text = "Primeira Nota:";
            // 
            // nota2
            // 
            nota2.AutoSize = true;
            nota2.Location = new Point(25, 144);
            nota2.Name = "nota2";
            nota2.Size = new Size(85, 15);
            nota2.TabIndex = 3;
            nota2.Text = "Segunda Nota:";
            // 
            // media
            // 
            media.AutoSize = true;
            media.Location = new Point(25, 173);
            media.Name = "media";
            media.Size = new Size(78, 15);
            media.TabIndex = 4;
            media.Text = "Media Aluno:";
            // 
            // textMatricula
            // 
            textMatricula.Location = new Point(126, 28);
            textMatricula.Name = "textMatricula";
            textMatricula.Size = new Size(353, 23);
            textMatricula.TabIndex = 5;
            // 
            // textNome
            // 
            textNome.Location = new Point(126, 86);
            textNome.Name = "textNome";
            textNome.Size = new Size(354, 23);
            textNome.TabIndex = 6;
            // 
            // textNota1
            // 
            textNota1.Location = new Point(126, 115);
            textNota1.Name = "textNota1";
            textNota1.Size = new Size(353, 23);
            textNota1.TabIndex = 7;
            // 
            // textNota2
            // 
            textNota2.Location = new Point(126, 144);
            textNota2.Name = "textNota2";
            textNota2.Size = new Size(353, 23);
            textNota2.TabIndex = 8;
            // 
            // textMedia
            // 
            textMedia.Location = new Point(126, 173);
            textMedia.Name = "textMedia";
            textMedia.Size = new Size(354, 23);
            textMedia.TabIndex = 9;
            // 
            // gravar
            // 
            gravar.Location = new Point(25, 213);
            gravar.Name = "gravar";
            gravar.Size = new Size(109, 23);
            gravar.TabIndex = 11;
            gravar.Text = "Gravar Dados";
            gravar.UseVisualStyleBackColor = true;
            gravar.Click += gravar_Click;
            // 
            // verificar
            // 
            verificar.Location = new Point(25, 242);
            verificar.Name = "verificar";
            verificar.Size = new Size(109, 23);
            verificar.TabIndex = 13;
            verificar.Text = "Verificar Dados";
            verificar.UseVisualStyleBackColor = true;
            verificar.Click += verificar_Click;
            // 
            // fechar
            // 
            fechar.Location = new Point(404, 213);
            fechar.Name = "fechar";
            fechar.Size = new Size(75, 23);
            fechar.TabIndex = 14;
            fechar.Text = "Sair";
            fechar.UseVisualStyleBackColor = true;
            fechar.Click += fechar_Click;
            // 
            // sala
            // 
            sala.AutoSize = true;
            sala.Location = new Point(25, 60);
            sala.Name = "sala";
            sala.Size = new Size(31, 15);
            sala.TabIndex = 15;
            sala.Text = "Sala:";
            // 
            // textSala
            // 
            textSala.Location = new Point(126, 57);
            textSala.Name = "textSala";
            textSala.Size = new Size(353, 23);
            textSala.TabIndex = 16;
            // 
            // bancoescola
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(503, 292);
            Controls.Add(textSala);
            Controls.Add(sala);
            Controls.Add(fechar);
            Controls.Add(verificar);
            Controls.Add(gravar);
            Controls.Add(textMedia);
            Controls.Add(textNota2);
            Controls.Add(textNota1);
            Controls.Add(textNome);
            Controls.Add(textMatricula);
            Controls.Add(media);
            Controls.Add(nota2);
            Controls.Add(nota1);
            Controls.Add(aluno);
            Controls.Add(matricula);
            Name = "bancoescola";
            Text = "Banco de Dados Escola";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label matricula;
        private Label aluno;
        private Label nota1;
        private Label nota2;
        private Label media;
        private TextBox textMatricula;
        private TextBox textNome;
        private TextBox textNota1;
        private TextBox textNota2;
        private TextBox textMedia;
        private Button gravar;
        private Button verificar;
        private Button fechar;
        private Label sala;
        private TextBox textSala;
    }
}