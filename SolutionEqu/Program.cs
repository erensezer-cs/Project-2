using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionEqu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] dizi = new double[6];
            double x1, x2, y1, y2, s1, s2, ssum, xsum, ysum, equx, equy, sonuc11, sonuc12;
            string value;

            while (true)
            {
                Console.Write("Please enter equations with how many unknows with number ?  : ");
                value = Console.ReadLine();
                try
                {
                    switch (Convert.ToInt32(value))
                    {
                        case 2:
                            Console.WriteLine("Please enter values : ");
                            for (int i = 0; i < dizi.Length; i++)
                            {
                                dizi[i] = Convert.ToDouble(Console.ReadLine());
                            }
                            Console.WriteLine("---------------------------------------------------------------");
                            Console.WriteLine("eq1 = " + dizi[0] + " " + dizi[1] + " " + dizi[2]);
                            Console.WriteLine("eq2 = " + dizi[3] + " " + dizi[4] + " " + dizi[5] + "\n");

                            Console.WriteLine("eq1 = " + dizi[0] + "*X1" + " + " + dizi[1] + "*X2" + "  = " + dizi[2]);
                            Console.WriteLine("eq2 = " + dizi[3] + "*X1" + " + " + dizi[4] + "*X2" + "  = " + dizi[5] + "\n" + "\n");


                            x1 = dizi[0] * dizi[4];
                            y1 = dizi[1] * dizi[4];
                            s1 = dizi[2] * dizi[4];

                            x2 = dizi[3] * (-1 * dizi[1]);
                            y2 = dizi[4] * (-1 * dizi[1]);
                            s2 = dizi[5] * (-1 * dizi[1]);

                            xsum = x1 + x2;
                            ysum = y1 + y2;
                            ssum = s1 + s2;

                            equx = ssum / xsum;
                            sonuc11 = Math.Round(equx, 2);
                            equy = (dizi[2] - (dizi[0] * equx)) / dizi[1];
                            sonuc12 = Math.Round(equy, 2);

                            Console.WriteLine("x1 = " + sonuc11);
                            Console.WriteLine("x2 = " + sonuc12);
                            Console.WriteLine("\n----------------------------------------------------------\n");
                            break;
                        case 3:
                            double[] dizi2 = new double[12];
                            double s3, k1, k2, k3, k4, k5, k6, k7, k8, k9, det, k11, k22, k33, k44, k55, k66, k77, k88, k99;

                            Console.WriteLine("Please enter values : ");
                            for (int i = 0; i < dizi2.Length; i++)
                            {
                                dizi2[i] = Convert.ToDouble(Console.ReadLine());
                            }

                            Console.Write("eq1 = " + dizi2[0] + " " + dizi2[1] + " " + dizi2[2] + " " + dizi2[3] + "\n");
                            Console.Write("eq2 = " + dizi2[4] + " " + dizi2[5] + " " + dizi2[6] + " " + dizi2[7] + "\n");
                            Console.Write("eq3 = " + dizi2[8] + " " + dizi2[9] + " " + dizi2[10] + " " + dizi2[11] + "\n");
                            Console.WriteLine("\n---------------------------------------------------------------");

                            Console.Write("eq1 = " + dizi2[0] + "*X1" + " + " + dizi2[1] + "*X2" + " + " + dizi2[2] + "*X3" + "  = " + dizi2[3] + "\n" + "\n");
                            Console.Write("eq2 = " + dizi2[4] + "*X1" + " + " + dizi2[5] + "*X2" + " + " + dizi2[6] + "*X3" + "  = " + dizi2[7] + "\n" + "\n");
                            Console.Write("eq3 = " + dizi2[8] + "*X1" + " + " + dizi2[9] + "*X2" + " + " + dizi2[10] + "*X3" + "  = " + dizi2[11] + "\n" + "\n");

                            det = dizi2[0] * (dizi2[5] * dizi2[10] - dizi2[6] * dizi2[9]) - dizi2[1] * (dizi2[4] * dizi2[10] - dizi2[6] * dizi2[8]) + dizi2[2] * (dizi2[4] * dizi2[9] - dizi2[5] * dizi2[8]);

                            k1 = (dizi2[5] * dizi2[10] - dizi2[6] * dizi2[9]);
                            k2 = (dizi2[1] * dizi2[10] - dizi2[2] * dizi2[9]) * (-1);
                            k3 = (dizi2[1] * dizi2[6] - dizi2[2] * dizi2[5]);
                            k4 = (dizi2[4] * dizi2[10] - dizi2[6] * dizi2[8]) * (-1);
                            k5 = (dizi2[0] * dizi2[10] - dizi2[2] * dizi2[8]);
                            k6 = (dizi2[0] * dizi2[6] - dizi2[2] * dizi2[4]) * (-1);
                            k7 = (dizi2[4] * dizi2[9] - dizi2[5] * dizi2[8]);
                            k8 = (dizi2[0] * dizi2[9] - dizi2[1] * dizi2[8]) * (-1);
                            k9 = (dizi2[0] * dizi2[5] - dizi2[1] * dizi2[4]);

                            k11 = k1 / det;
                            k22 = k2 / det;
                            k33 = k3 / det;
                            k44 = k4 / det;
                            k55 = k5 / det;
                            k66 = k6 / det;
                            k77 = k7 / det;
                            k88 = k8 / det;
                            k99 = k9 / det;

                            s1 = (k11 * dizi2[3]) + (k22 * dizi2[7]) + (k33 * dizi2[11]);
                            s2 = (k44 * dizi2[3]) + (k55 * dizi2[7]) + (k66 * dizi2[11]);
                            s3 = (k77 * dizi2[3]) + (k88 * dizi2[7]) + (k99 * dizi2[11]);


                            Console.WriteLine("\n\n");
                            Console.WriteLine("x1 = " + s1);
                            Console.WriteLine("x2 = " + s2);
                            Console.WriteLine("x3 = " + s3);
                            Console.WriteLine("\n----------------------------------------------------------\n\n");
                            break;
                        case 4:
                            double[] dizi3 = new double[20];
                            double det2, b11, b12, b13, b14, b21, b22, b23, b24, b31, b32, b33, b34, b41, b42, b43, b44, p1, p2, p3, p4;

                            Console.WriteLine("Please enter values : ");

                            for (int i = 0; i < dizi3.Length; i++)
                            {
                                dizi3[i] = Convert.ToDouble(Console.ReadLine());
                            }

                            Console.Write("eq1 = " + dizi3[0] + " " + dizi3[1] + " " + dizi3[2] + " " + dizi3[3] + " " + dizi3[4] + "\n");
                            Console.Write("eq2 = " + dizi3[5] + " " + dizi3[6] + " " + dizi3[7] + " " + dizi3[8] + " " + dizi3[9] + "\n");
                            Console.Write("eq3 = " + dizi3[10] + " " + dizi3[11] + " " + dizi3[12] + " " + dizi3[13] + " " + dizi3[14] + "\n");
                            Console.Write("eq4 = " + dizi3[15] + " " + dizi3[16] + " " + dizi3[17] + " " + dizi3[18] + " " + dizi3[19] + "\n");
                            Console.WriteLine("\n---------------------------------------------------------------");

                            Console.Write("eq1 = " + dizi3[0] + "*X1" + " + " + dizi3[1] + "*X2" + " + " + dizi3[2] + "*X3" + " + " + dizi3[3] + "*X4" + "  = " + dizi3[4] + "\n" + "\n");
                            Console.Write("eq2 = " + dizi3[5] + "*X1" + " + " + dizi3[6] + "*X2" + " + " + dizi3[7] + "*X3" + " + " + dizi3[8] + "*X4" + "  = " + dizi3[9] + "\n" + "\n");
                            Console.Write("eq3 = " + dizi3[10] + "*X1" + " + " + dizi3[11] + "*X2" + " + " + dizi3[12] + "*X3" + " + " + dizi3[13] + "*X4" + "  = " + dizi3[14] + "\n" + "\n");
                            Console.Write("eq4 = " + dizi3[15] + "*X1" + " + " + dizi3[16] + "*X2" + " + " + dizi3[17] + "*X3" + " + " + dizi3[18] + "*X4" + "  = " + dizi3[19] + "\n" + "\n");


                            det2 = (dizi3[0] * dizi3[6] * dizi3[12] * dizi3[18]) + (dizi3[0] * dizi3[7] * dizi3[13] * dizi3[16]) + (dizi3[0] * dizi3[8] * dizi3[11] * dizi3[17]) + (dizi3[1] * dizi3[5] * dizi3[13] * dizi3[17]) + (dizi3[1] * dizi3[7] * dizi3[10] * dizi3[18]) + (dizi3[1] * dizi3[8] * dizi3[12] * dizi3[15]) + (dizi3[2] * dizi3[5] * dizi3[11] * dizi3[18]) +
                                (dizi3[2] * dizi3[6] * dizi3[13] * dizi3[15]) + (dizi3[2] * dizi3[8] * dizi3[10] * dizi3[16]) + (dizi3[3] *
                                dizi3[5] * dizi3[12] * dizi3[16]) + (dizi3[3] * dizi3[6] * dizi3[10] * dizi3[17]) + (dizi3[3] * dizi3[7] *
                                dizi3[11] * dizi3[15]) - (dizi3[0] * dizi3[6] * dizi3[13] * dizi3[17]) - (dizi3[0] * dizi3[7] * dizi3[11] *
                                dizi3[18]) - (dizi3[0] * dizi3[8] * dizi3[12] * dizi3[16]) - (dizi3[1] * dizi3[5] * dizi3[12] * dizi3[18]) -
                                (dizi3[1] * dizi3[7] * dizi3[13] * dizi3[15]) - (dizi3[1] * dizi3[8] * dizi3[10] * dizi3[17]) -
                                (dizi3[2] * dizi3[5] * dizi3[13] * dizi3[16]) - (dizi3[2] * dizi3[6] * dizi3[10] * dizi3[18]) -
                                (dizi3[2] * dizi3[8] * dizi3[11] * dizi3[15]) - (dizi3[3] * dizi3[5] * dizi3[11] * dizi3[17]) - (dizi3[3] *
                                dizi3[6] * dizi3[12] * dizi3[15]) - (dizi3[3] * dizi3[7] * dizi3[10] * dizi3[16]);

                            b11 = ((dizi3[6] * dizi3[12] * dizi3[18]) + (dizi3[7] * dizi3[13] * dizi3[16]) + (dizi3[8] * dizi3[11] * dizi3[17]) - (dizi3[6] * dizi3[13] * dizi3[17]) - (dizi3[7] * dizi3[11] * dizi3[18]) - (dizi3[8] * dizi3[12] * dizi3[16])) / det2;

                            b12 = (-(dizi3[1] * dizi3[12] * dizi3[18]) + (dizi3[1] * dizi3[13] * dizi3[17]) + (dizi3[11] * dizi3[2] * dizi3[18]) - (dizi3[11] * dizi3[3] * dizi3[17]) - (dizi3[16] * dizi3[2] * dizi3[13]) + (dizi3[16] * dizi3[3] * dizi3[12])) / det2;

                            b13 = (dizi3[1] * dizi3[7] * dizi3[18] - dizi3[1] * dizi3[8] * dizi3[17] - dizi3[6] * dizi3[2] * dizi3[18] + dizi3[6] * dizi3[3] * dizi3[17] + dizi3[16] * dizi3[2] * dizi3[8] - dizi3[16] * dizi3[3] * dizi3[7]) / det2;

                            b14 = (-dizi3[1] * dizi3[7] * dizi3[13] + dizi3[1] * dizi3[8] * dizi3[12] + dizi3[6] * dizi3[2] * dizi3[13] - dizi3[6] * dizi3[3] * dizi3[12] - dizi3[11] * dizi3[2] * dizi3[8] + dizi3[11] * dizi3[3] * dizi3[7]) / det2;

                            b21 = (-dizi3[5] * dizi3[12] * dizi3[18] + dizi3[5] * dizi3[13] * dizi3[17] + dizi3[10] * dizi3[7] * dizi3[18] - dizi3[10] * dizi3[8] * dizi3[17] - dizi3[15] * dizi3[7] * dizi3[13] + dizi3[15] * dizi3[8] * dizi3[12]) / det2;

                            b22 = (dizi3[0] * dizi3[12] * dizi3[18] - dizi3[0] * dizi3[13] * dizi3[17] - dizi3[10] * dizi3[2] * dizi3[18] + dizi3[10] * dizi3[3] * dizi3[17] + dizi3[15] * dizi3[2] * dizi3[13] - dizi3[15] * dizi3[3] * dizi3[12]) / det2;

                            b23 = (-dizi3[0] * dizi3[7] * dizi3[18] + dizi3[0] * dizi3[8] * dizi3[17] + dizi3[5] * dizi3[2] * dizi3[18] - dizi3[5] * dizi3[3] * dizi3[17] - dizi3[15] * dizi3[2] * dizi3[8] + dizi3[15] * dizi3[3] * dizi3[7]) / det2;

                            b24 = (dizi3[0] * dizi3[7] * dizi3[13] - dizi3[0] * dizi3[8] * dizi3[12] - dizi3[5] * dizi3[2] * dizi3[13] + dizi3[5] * dizi3[3] * dizi3[12] + dizi3[10] * dizi3[2] * dizi3[8] - dizi3[10] * dizi3[3] * dizi3[7]) / det2;

                            b31 = (dizi3[5] * dizi3[11] * dizi3[18] - dizi3[5] * dizi3[13] * dizi3[16] - dizi3[10] * dizi3[6] * dizi3[18] + dizi3[10] * dizi3[8] * dizi3[16] + dizi3[15] * dizi3[6] * dizi3[13] - dizi3[15] * dizi3[8] * dizi3[11]) / det2;

                            b32 = (-dizi3[0] * dizi3[11] * dizi3[18] + dizi3[0] * dizi3[13] * dizi3[16] + dizi3[10] * dizi3[1] * dizi3[18] - dizi3[10] * dizi3[3] * dizi3[16] - dizi3[15] * dizi3[1] * dizi3[13] + dizi3[15] * dizi3[3] * dizi3[11]) / det2;

                            b33 = (dizi3[0] * dizi3[6] * dizi3[18] - dizi3[0] * dizi3[8] * dizi3[16] - dizi3[5] * dizi3[1] * dizi3[18] + dizi3[5] * dizi3[3] * dizi3[16] + dizi3[15] * dizi3[1] * dizi3[8] - dizi3[15] * dizi3[3] * dizi3[6]) / det2;

                            b34 = (-dizi3[0] * dizi3[6] * dizi3[13] + dizi3[0] * dizi3[8] * dizi3[11] + dizi3[5] * dizi3[1] * dizi3[13] - dizi3[5] * dizi3[3] * dizi3[11] - dizi3[10] * dizi3[1] * dizi3[8] + dizi3[10] * dizi3[3] * dizi3[6]) / det2;

                            b41 = (-dizi3[5] * dizi3[11] * dizi3[17] + dizi3[5] * dizi3[12] * dizi3[16] + dizi3[10] * dizi3[6] * dizi3[17] - dizi3[10] * dizi3[7] * dizi3[16] - dizi3[15] * dizi3[6] * dizi3[12] + dizi3[15] * dizi3[7] * dizi3[11]) / det2;

                            b42 = (dizi3[0] * dizi3[11] * dizi3[17] - dizi3[0] * dizi3[12] * dizi3[16] - dizi3[10] * dizi3[1] * dizi3[17] + dizi3[10] * dizi3[2] * dizi3[16] + dizi3[15] * dizi3[1] * dizi3[12] - dizi3[15] * dizi3[2] * dizi3[11]) / det2;

                            b43 = (-dizi3[0] * dizi3[6] * dizi3[17] + dizi3[0] * dizi3[7] * dizi3[16] + dizi3[5] * dizi3[1] * dizi3[17] - dizi3[5] * dizi3[2] * dizi3[16] - dizi3[15] * dizi3[1] * dizi3[7] + dizi3[15] * dizi3[2] * dizi3[6]) / det2;

                            b44 = (dizi3[0] * dizi3[6] * dizi3[12] - dizi3[0] * dizi3[7] * dizi3[11] - dizi3[5] * dizi3[1] * dizi3[12] + dizi3[5] * dizi3[2] * dizi3[11] + dizi3[10] * dizi3[1] * dizi3[7] - dizi3[10] * dizi3[2] * dizi3[6]) / det2;


                            p1 = (b11 * dizi3[4]) + (b12 * dizi3[9]) + (b13 * dizi3[14]) + (b14 * dizi3[19]);
                            p2 = (b21 * dizi3[4]) + (b22 * dizi3[9]) + (b23 * dizi3[14]) + (b24 * dizi3[19]);
                            p3 = (b31 * dizi3[4]) + (b32 * dizi3[9]) + (b33 * dizi3[14]) + (b34 * dizi3[19]);
                            p4 = (b41 * dizi3[4]) + (b42 * dizi3[9]) + (b43 * dizi3[14]) + (b44 * dizi3[19]);

                            Console.WriteLine("\n\n");
                            Console.WriteLine("x1 = " + Convert.ToInt16(p1));
                            Console.WriteLine("x2 = " + Convert.ToInt16(p2));
                            Console.WriteLine("x3 = " + Convert.ToInt16(p3));
                            Console.WriteLine("x4 = " + Convert.ToInt16(p4));
                            Console.WriteLine("\n----------------------------------------------------------\n\n");

                            break;
                        default:
                            Console.WriteLine("Please enter valid value !!!\n\n");
                            Console.WriteLine("\n----------------------------------------------------------\n");
                            break;
                    }
                    }
                catch (Exception)
                {
                    Console.WriteLine("Please enter valid value !!!\n\n");
                    Console.WriteLine("\n----------------------------------------------------------\n");
                }
                
                

            }
            Console.Read();

        }
    }
}
