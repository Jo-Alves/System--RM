using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatorioMei
{
    public class DOC
    {
        public static bool ValidaCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public static bool ValidarCNPJ(string CNPJ)
        {
            try
            {
                if (!(CNPJ.Length < 18))
                {
                    int n1 = Convert.ToInt16(CNPJ.Substring(0, 1));
                    int n2 = Convert.ToInt16(CNPJ.Substring(1, 1));
                    int n3 = Convert.ToInt16(CNPJ.Substring(3, 1));
                    int n4 = Convert.ToInt16(CNPJ.Substring(4, 1));
                    int n5 = Convert.ToInt16(CNPJ.Substring(5, 1));
                    int n6 = Convert.ToInt16(CNPJ.Substring(7, 1));
                    int n7 = Convert.ToInt16(CNPJ.Substring(8, 1));
                    int n8 = Convert.ToInt16(CNPJ.Substring(9, 1));
                    int n9 = Convert.ToInt16(CNPJ.Substring(11, 1));
                    int n10 = Convert.ToInt16(CNPJ.Substring(12, 1));
                    int n11 = Convert.ToInt16(CNPJ.Substring(13, 1));
                    int n12 = Convert.ToInt16(CNPJ.Substring(14, 1));

                    int digito1 = Convert.ToInt16(CNPJ.Substring(16, 1));
                    int digito2 = Convert.ToInt16(CNPJ.Substring(17, 1));

                    int soma1 = n1 * 5 + n2 * 4 + n3 * 3 + n4 * 2 + n5 * 9 + n6 * 8 + n7 * 7 + n8 * 6 + n9 * 5 + n10 * 4 + n11 * 3 + n12 * 2;

                    int digitoVerificador = soma1 % 11;
                    if (digitoVerificador < 2)
                    {
                        digitoVerificador = 0;
                    }
                    else
                    {
                        digitoVerificador = 11 - digitoVerificador;
                    }

                    int soma2 = n1 * 6 + n2 * 5 + n3 * 4 + n4 * 3 + n5 * 2 + n6 * 9 + n7 * 8 + n8 * 7 + n9 * 6 + n10 * 5 + n11 * 4 + n12 * 3 + digitoVerificador * 2;

                    int digitoVerificador2 = soma2 % 11;

                    if (digitoVerificador2 < 2)
                    {
                        digitoVerificador2 = 0;
                    }
                    else
                    {
                        digitoVerificador2 = 11 - digitoVerificador2;
                    }
                    if (digito1 == digitoVerificador && digito2 == digitoVerificador2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
