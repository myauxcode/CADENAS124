
        //EJERCICIO 1
        static string ejercicio1(string entrada)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < entrada.Length; i++)
            {
                char c = entrada[i];
                if (char.IsLetter(c) || char.IsDigit(c) || char.IsWhiteSpace(c))
                {
                    resultado.Append(c);
                }
            }

            return resultado.ToString();
        }

        //LLAMDADA
        private void eJERCICIO1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = string.Concat(ejercicio1((textBox1.Text)));
        }


        //EJERCICIO 2
        public string ejercicio2(string s)
        {
            string[] palabras = s.Split(' ');
            string resultado = "";

            for (int i = 0; i < palabras.Length; i++)
            {
                string palabra = palabras[i];
                int numVocales = 0;
                int numConsonantes = 0;

                for (int j = 0; j < palabra.Length; j++)
                {
                    char c = palabra[j];
                    if (EsVocal(c))
                    {
                        numVocales++;
                    }
                    else if (char.IsLetter(c) && !EsVocal(c))
                    {
                        numConsonantes++;
                    }
                }

                if (numConsonantes > numVocales)
                {
                    if (resultado.Length > 0)
                    {
                        resultado += " ";
                    }
                    resultado += palabra;
                }
            }

            return resultado;
        }

        private bool EsVocal(char c)
        {
            char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            for (int i = 0; i < vocales.Length; i++)
            {
                if (vocales[i] == c)
                {
                    return true;
                }
            }
            return false;
        }

        //LLAMDADA

        private void eJERCICIO2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = string.Concat(ejercicio2((textBox1.Text)));
        }

