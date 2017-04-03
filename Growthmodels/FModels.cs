using System;
using System.Collections.Generic;
using System.Linq;

namespace Growthmodels
{
    //Thinning Class model
    /// <summary> FModels: Forest Growth Models</summary>
    public class  FModels
    {
        
        #region Dynamic Growth Model 1

                #region DLL Info Model 1
                public class DLLInfoModel1
                            {
                                // Generic
                                public String Especie = "Pinus pinaster";

                                // Dinamic model
                                //Age limitations
                                public double Maxt = 60;
                                public double Mint = 5;

                                //N limitations
                                public double MaxN = 3700;
                                public double MinN = 400;

                                //Transition equation for Dominant Height
                                public string TransHShortRefH0 = "Tomé  (2001)";
                                public string TransHLongRefH0 = "Tomé M. (2001) Tabela de produção geral para o pinheiro bravo desenvolvida no âmbito do projecto PAMAF 8165 “Regeneração, Condução e Crescimento do Pinhal Bravo das Regiões Litoral e Interior Centro”. Relatórios técnico-científicos do GIMREF RT9/2001. Centro de Estudos Florestais, Instituto Superior de Agronomia, Lisboa. [in Portuguese] ";
                                public double MaxH0 = 30;
                                public double MinH0 = 3;
                                
                                //
                                //Transition equation for Basal Area
                                public string TransHShortRefG = "Páscoa (1987)";
                                public string TransHLongRefG = "Páscoa F. (1987) Estrutura, Crescimento e Produção em Povoamentos de Pinheiro Bravo. Um Modelo de Simulação. Tese de Doutoramento. ISA/UTL. Lisboa (241 pp.)";
                                public double MaxG = 80;
                                public double MinG = 1;
                                public int InicG = 1; //Inicialication available = 1, unavailable: 0
                                //
                                //Transition equation for Inicialization of Basal Area
                                public string TransHShortRefIniG = "Páscoa (1987)";
                                public string TransHLongRefIniG = "Páscoa F. (1987) Estrutura, Crescimento e Produção em Povoamentos de Pinheiro Bravo. Um Modelo de Simulação. Tese de Doutoramento. ISA/UTL. Lisboa (241 pp.)";

                                //Biomass equation
                                public string TransHShortRefW = "Dieguez-Aranda (2009)";
                                public string TransHLongRefW = "Diéguez-Aranda U., Rojo-Alboreca A., Castedo-Dorado F., Álvarez-González J.G., Barrio-Anta M., Crecente-Campo F., González-González J.M., Pérez-Cruzado C., Rodríguez-Soalleiro R., López-Sánchez C.A., Balboa-Murias M.A., Gorgoso-Varela J.J., Sánchez-Rodríguez F. (2009) Herramientas selvícolas para la gestión forestal sostenible en Galicia. Consellería do Medio Rural, Xunta de Galicia. 268 pp + CD-Rom.";

                                //Carbon equation
                                public string TransHShortRefC = "Dieguez-Aranda (2009)";
                                public string TransHLongRefC = "Diéguez-Aranda U., Rojo-Alboreca A., Castedo-Dorado F., Álvarez-González J.G., Barrio-Anta M., Crecente-Campo F., González-González J.M., Pérez-Cruzado C., Rodríguez-Soalleiro R., López-Sánchez C.A., Balboa-Murias M.A., Gorgoso-Varela J.J., Sánchez-Rodríguez F. (2009) Herramientas selvícolas para la gestión forestal sostenible en Galicia. Consellería do Medio Rural, Xunta de Galicia. 268 pp + CD-Rom."; 

                                public int mort = 1; //0 = none, 1 = Max density equation, 2 = mortality equation
                                //
                                //Transition equation density
                                public string TransHShortRefMaxN = "Luis & Fonseca (2004)";
                                public string TransHLongRefMaxN = "Luis J.F.S., Fonseca T. (2004) The allometric model in the stand density management of Pinus pinaster Ait. in Portugal. Annals of Forest Science, Springer Verlag 61 (8):807-814.";
                                public double average_plantation_density = 1500;
                                public double average_limite_sup_density = 1200;
                    
                                //
                                //Transition equation for Volume with Cork
                                public string TransHShortRefVCC = "Luis & Fonseca (2004)";
                                public string TransHLongRefVCC = "Luis J.F.S., Fonseca T. (2004) The allometric model in the stand density management of Pinus pinaster Ait. in Portugal. Annals of Forest Science, Springer Verlag 61 (8):807-814.";
                                //
                                //Transition equation for Volume Without Cork 
                                public string TransHShortRefVSC;
                                public string TransHLongRefVCS;
                                //

                                //Quality of site idex
                                //values are the inferior limit
                                public double VeryGood = 26;
                                public double Good = 21;
                                public double Moderate = 16;
                                public double Low = 11;
                                public double AgeRefSiteIndex = 40;
                                public double MaxQuality = 28;

                                // Individual tree model
                                //Relation average diameter with cuadratic diameter
                                public string TransHShortRefd_dd = "Fonseca (2004)";
                                public string TransHLongRefd_dd = "Fonseca T. (2004) Modelação do crescimento, mortalidade e distribuição diamétrica, do pinhal bravo no Vale do Tâmega. University of Trás-os-Montes e Alto Douro, PhD Thesis, Vila Real, Portugal, pp. 248. ";
                                //
                                //Relation diameter with height
                                public string TransHShortRefd_h = "Almeida (1999)";
                                public string TransHLongRefd_h = "Almeida L.F.R. (1999) Comparação de metodologias para estimação de altura e volume em povoamento s de pinheiro bravo no Vale do Tâmega, Relatório final de estágio. UTAD, Vila Real, 114 pp ";
                                //
                                //Individual volume with cork
                                public string TransHShortvcc = "Nunes et al. (2010)";
                                public string TransHLongvcc = "Nunes L., Tomé J., Tomé M. (2010) A system for compatible prediction of total and merchantable volumes allowing for different definitions of tree volume. Canadian Journal of Forest Research. ISSN 1208-6037. 40:4, p. 747-760.";
                                //

                                // Thinning Willson Factor
                                public double FactorwillsonLow = 0.16;
                                public double FactorwillsonModerate = 0.20;
                                public double FactorwillsonModerate_high = 0.23;
                                public double FactorwillsonHigh = 0.28;

                            }
                #endregion

                #region Dinamic Growth Model Model 1
                /// <summary> Dinamic growth model for Model1</summary>
                public class GrowthEquationsModel1
                {
                    //Modified for your region only the equation

                    /// <summary> TransH: Transition H0 equation</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="t1"> Actual age (years) </param>
                    /// <param name="t2"> Age to the future(years) </param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public double Ht1_t2(double H0, double N, double G, double t1, double t2)
                    {
                        //Equation
                        return 69 * Math.Pow((H0 / 69), Math.Pow((t1 / t2), 0.458203));
                    }

                    /// <summary> InicG: Initialized Basal Area (m2/ha)</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="t1"> Actual age (years) </param>
                    /// <param name="t2"> Age to the future(years) </param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public double InicG(double H0, double N, double G, double t1, double t2)
                    {
                        DLLInfoModel1 info = new DLLInfoModel1();
                        //Equation
                        //double X0 = (4.363) * Math.Pow(H0_tRef(H0, t1, 20, N, G).H1, 0.07383);
                        //double result_G = Math.Exp(X0) * Math.Exp(-(-167.5 + (999.1) / X0) * Math.Pow(t1, -0.8936));
                        double result_G = 0.000984 * Math.Pow(H0, 2.103402) * Math.Pow(N, 0.797707) * Math.Exp(-8.702327 / t1); 
                        return result_G;
                    }

                    /// <summary> G1: Simulate the Basal Area in an age in the future</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="t1"> Actual age (years) </param>
                    /// <param name="t2"> Age to the future(years) </param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public double Gt1_t2(double H0, double N, double G, double t1, double t2)
                    {
                        //Equation
                        //double X0 = (Math.Pow(t1, -0.8936) / 2) * (-167.5 + Math.Pow(t1, 0.8936) * Math.Log(G) + Math.Sqrt(4 * (999.1 ) * Math.Pow(t1, 0.8936) + Math.Pow(167.5 - Math.Pow(t1, 0.8936) * Math.Log(G), 2)));
                        //double result_G = Math.Exp(X0) * Math.Exp(-(-167.5 + (999.1) / X0) * Math.Pow(t2, -0.8936));
                        double X0 = ((1- t1/t2)* (4.178774+0.039053*H0));
                        double result_G = Math.Pow(G, (t1 / t2)) * Math.Exp(X0);
                        return result_G;
                    }

                    /// <summary> Nmax: alometric model, Max density</summary>
                    /// <param name="N"> Density </param>
                    /// <param name="G"> Basal Area </param>m>
                    public double MaxN(double N, double G)
                    {
                        DLLInfoModel1 infoM1 = new DLLInfoModel1();
                        double dg = Math.Sqrt((4 * G) / (Math.PI * infoM1.average_plantation_density)) * 100;
                        double Result_N = Math.Exp(13.123 - 1.897 * Math.Log(dg));
                        return Result_N;
                    }

                    /// <summary> Mortality equation</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="t1"> Actual age (years) </param>
                    /// <param name="t2"> Age to the future(years) </param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>m>
                    public double Nt1_t2(double H0, double N, double G, double t1, double t2)
                    {
                        //insert equation of mortality

                        return N;
                    }

                    /// <summary> VCC: Volume with cork (m3/ha)</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public double VCC(double H0, double N, double G)
                    {
                        //Equation
                        double dg = Math.Sqrt((4 * G) / (Math.PI * N)) * 100;
                        double V = 0.063 * Math.Pow(dg, 2.096) * Math.Pow(H0, 0.668) * Math.Pow(N / 1000, 0.978);
                        return V;
                    }

                    /// <summary> W: Total biomass weight with cork (tons) </summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public double W(double H0, double N, double G)
                    {
                        //Equation
                        double dg = Math.Sqrt((4 * G) / (Math.PI * N)) * 100;
                        double w = 0.0003390 * Math.Pow(dg, 1.284) * Math.Pow(H0, 1.465) * Math.Pow(N, 0.7277);
                        return w;
                    }

                    // Carbon factor 
                    public double C(double W)
                    {
                        //Equation Dieguez-Aranda 2009
                        return W * 0.479;
                    }

                    //Non modified
                    /// <summary> H1: Dominant height (m) at t2</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="t1"> Actual age (years) </param>
                    /// <param name="t2"> Age to the future(years) </param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public SiteClass H0_tRef(double H0, double t1,  double t2, double N, double G)
                    {
                        DLLInfoModel1 info = new DLLInfoModel1();
                        SiteClass SI = new SiteClass();
                        if (t2 == 0)
                        {
                            t2 = info.AgeRefSiteIndex;
                        }
                        SI.H1 = Ht1_t2(H0, N, G, t1, t2);
                        double H2 = Ht1_t2(H0, N, G, t1, info.AgeRefSiteIndex);

                        if (H2 > info.VeryGood)
                        {
                            SI.Quality = "Very good";
                        }
                        else if (H2 > info.Good)
                        {
                            SI.Quality = "Good";
                        }
                        else if (H2 > info.Moderate)
                        {
                            SI.Quality = "Moderate";
                        }
                        else if (H2 > info.Low)
                        {
                            SI.Quality = "Low";
                        }
                        else
                        {
                            SI.Quality = "Very low";
                        }

                        return SI;
                    }

                    /// <summary> VCC: Simulate the volume with cork (m3/ha) to an age in future</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="N"> Number of tree per hectare (ud/ha)</param>
                    /// <param name="I"> Dummy variable (I) is equal to 0 for Pinus pinaster coast variety and 1 for interior variety.</param>
                    /// <param name="t"> Actual age (years) </param>
                    /// <param name="G"> Basal area (m2/ha) </param>
                    public double VCC(double H0, double N, double t, double G = 0)
                    {
                        ThinningclassModel1 a = new ThinningclassModel1();
                        double V = a.thinningDesign(H0, N, G, t, 1, N, 0).Ve;
                        return V;
                    }
                }
                #endregion   

        #endregion

        #region Dynamic Growth Model 2

                #region DLL Info Model 2
                public class DLLInfoModel2
                {
                    // Generic
                    public String Especie = "Quercus pyrenaica";

                    // Dinamic model
                    //Age limitations
                    public double Maxt = 120;
                    public double Mint = 15;

                    //N limitations
                    public double MaxN = 3500;
                    public double MinN = 400;

                    //Transition equation for Dominant Height
                    public string TransHShortRefH0 = "Carvalho (2000)";
                    public string TransHLongRefH0 = "Carvalho (2000) Crescimento, Produção e ecologia de povoamentos de Quercus pyrenaica Willd. em Portugal Continental. Universidade de Trás-os-Montes de Alto Douro. Vila Real";
                    public double MaxH0 = 30;
                    public double MinH0 = 5;
                    //
                    //Transition equation for Basal Area
                    public string TransHShortRefG = "Carvalho (2000)";
                    public string TransHLongRefG = "Carvalho (2000) Crescimento, Produção e ecologia de povoamentos de Quercus pyrenaica Willd. em Portugal Continental. Universidade de Trás-os-Montes de Alto Douro. Vila Real";
                    public double MaxG = 80;
                    public double MinG = 10;
                    public int InicG = 0; //Inicialication available = 1, unavailable: 0
                     //
                    //Transition equation for Inicialization of Basal Area
                    public string TransHShortRefIniG = "Carvalho (2000)";
                    public string TransHLongRefIniG = "Carvalho (2000) Crescimento, Produção e ecologia de povoamentos de Quercus pyrenaica Willd. em Portugal Continental. Universidade de Trás-os-Montes de Alto Douro. Vila Real";

                    //Biomass equation
                    public string TransHShortRefW = "Carvalho (2000)";
                    public string TransHLongRefW = "Carvalho (2000) Crescimento, Produção e ecologia de povoamentos de Quercus pyrenaica Willd. em Portugal Continental. Universidade de Trás-os-Montes de Alto Douro. Vila Real";

                    //Carbon equation
                    public string TransHShortRefC = "Carvalho (2000)";
                    public string TransHLongRefC = "Carvalho (2000) Crescimento, Produção e ecologia de povoamentos de Quercus pyrenaica Willd. em Portugal Continental. Universidade de Trás-os-Montes de Alto Douro. Vila Real"; 

                    //
                    public int mort = 2; //0 = none, 1 = Max density equation, 2 = mortality equation
                    //
                    //Transition equation for Density
                    public string TransHShortRefMaxN = "Carvalho (2000)";
                    public string TransHLongRefMaxN = "Carvalho (2000) Crescimento, Produção e ecologia de povoamentos de Quercus pyrenaica Willd. em Portugal Continental. Universidade de Trás-os-Montes de Alto Douro. Vila Real";
                    //
                    //Transition equation for Volume with Cork
                    public string TransHShortRefVCC = "Carvalho (2000)";
                    public string TransHLongRefVCC = "Carvalho (2000) Crescimento, Produção e ecologia de povoamentos de Quercus pyrenaica Willd. em Portugal Continental. Universidade de Trás-os-Montes de Alto Douro. Vila Real";
                    //
                    //Transition equation for Volume Without Cork 
                    public string TransHShortRefVSC;
                    public string TransHLongRefVCS;
                    //

                    //Quality of site idex
                    //values are the inferior limit
                    public double VeryGood = 16;
                    public double Good = 13;
                    public double Moderate = 10;
                    public double Low = 7;
                    public double AgeRefSiteIndex = 40;
                    public double MaxQuality = 20;

                    // Individual tree model
                    //Relation average diameter with cuadratic diameter
                    public string TransHShortRefd_dd = "Carvalho (2000)";
                    public string TransHLongRefd_dd = "Carvalho (2000) Crescimento, Produção e ecologia de povoamentos de Quercus pyrenaica Willd. em Portugal Continental. Universidade de Trás-os-Montes de Alto Douro. Vila Real";
                    //
                    //Relation diameter with height
                    public string TransHShortRefd_h = "Carvalho (2000)";
                    public string TransHLongRefd_h = "Carvalho (2000) Crescimento, Produção e ecologia de povoamentos de Quercus pyrenaica Willd. em Portugal Continental. Universidade de Trás-os-Montes de Alto Douro. Vila Real";
                    //
                    //Individual volume with cork
                    public string TransHShortvcc = "Carvalho (2000)";
                    public string TransHLongvcc = "Carvalho (2000) Crescimento, Produção e ecologia de povoamentos de Quercus pyrenaica Willd. em Portugal Continental. Universidade de Trás-os-Montes de Alto Douro. Vila Real";
                    //

                    // Thinning Willson Factor
                    public double FactorwillsonLow = 0.16;
                    public double FactorwillsonModerate = 0.20;
                    public double FactorwillsonModerate_high = 0.23;
                    public double FactorwillsonHigh = 0.28;

                }
                #endregion

                #region Dinamic Growth Model Model 2
                /// <summary> Dinamic growth model for Model1</summary>
                public class GrowthEquationsModel2
                {
                    //Modified for your region only the equation

                    /// <summary> TransH: Transition H0 equation</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="t1"> Actual age (years) </param>
                    /// <param name="t2"> Age to the future(years) </param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public double Ht1_t2(double H0, double N, double G, double t1, double t2)
                    {
                        //Equation
                        double td1 = (t1 - 4.288) / 0.999;
                        double td2 = (t2 - 4.288) / 0.999;
                        double Ht2 = Math.Exp(Math.Log(H0) + 0.915 * Math.Log((1 - Math.Exp(-0.0210 * td2)) / (1 - Math.Exp(-0.0210 * td1))));
                        return Ht2;
                    }

                    /// <summary> InicG: Initialized Basal Area (m2/ha)</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="t1"> Actual age (years) </param>
                    /// <param name="t2"> Age to the future(years) </param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public double InicG(double H0, double N, double G, double t1, double t2)
                    {
                        //Equation

                        return 0;
                    }

                    /// <summary> G1: Simulate the Basal Area in an age in the future</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="t1"> Actual age (years) </param>
                    /// <param name="t2"> Age to the future(years) </param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public double Gt1_t2(double H0, double N, double G, double t1, double t2)
                    {
                        //Equation
                        double Xd = 0;
                        double result_G = Math.Pow(G,t1/t2)*Math.Exp(4.165*(1-t1/t2)-0.677*Xd*(1-t1/t2));
                        return result_G;
                    }

                    /// <summary> Nmax: alometric model, Max density</summary>
                    /// <param name="N"> Density </param>
                    /// <param name="G"> Basal Area </param>m>
                    public double MaxN(double N, double G)
                    {

                        return 0;
                    }

                    /// <summary> Mortality equation</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="t1"> Actual age (years) </param>
                    /// <param name="t2"> Age to the future(years) </param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>m>
                    public double Nt1_t2(double H0, double N, double G, double t1, double t2)
                    {
                        //insert equation of mortality

                        double N2 = N * Math.Exp(-0.0237 * (t2 - t1) + 0.345 * Math.Log(t2 / t1));

                        return N2;
                    }

                    /// <summary> VCC: Volume with cork (m3/ha)</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public double VCC(double H0, double N, double G)
                    {
                        //Equation
                        double V = 6.382 + 0.412 * (H0 * G);
                        return V;
                    }

                    /// <summary> W: Total biomass weight with cork (tons) </summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public double W(double H0, double N, double G)
                    {
                        //Equation
                        double w = 0.277 * (H0 * G);
                        return w;
                    }

                    // Carbon factor 
                    public double C(double W)
                    {
                        //Equation Dieguez-Aranda 2009
                        return W * 0.479;
                    }

                    //Non modified
                    /// <summary> H1: Dominant height (m) at t2</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="t1"> Actual age (years) </param>
                    /// <param name="t2"> Age to the future(years) </param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public SiteClass H0_tRef(double H0, double t1, double t2, double N, double G)
                    {
                        DLLInfoModel1 info = new DLLInfoModel1();
                        SiteClass SI = new SiteClass();
                        if (t2 == 0)
                        {
                            t2 = info.AgeRefSiteIndex;
                        }
                        SI.H1 = Ht1_t2(H0, N, G, t1, t2);
                        double H2 = Ht1_t2(H0, N, G, t1, info.AgeRefSiteIndex);

                        if (H2 > info.VeryGood)
                        {
                            SI.Quality = "Very good";
                        }
                        else if (H2 > info.Good)
                        {
                            SI.Quality = "Good";
                        }
                        else if (H2 > info.Moderate)
                        {
                            SI.Quality = "Moderate";
                        }
                        else if (H2 > info.Low)
                        {
                            SI.Quality = "Low";
                        }
                        else
                        {
                            SI.Quality = "Very low";
                        }

                        return SI;
                    }

                    /// <summary> VCC: Simulate the volume with cork (m3/ha) to an age in future</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="N"> Number of tree per hectare (ud/ha)</param>
                    /// <param name="I"> Dummy variable (I) is equal to 0 for Pinus pinaster coast variety and 1 for interior variety.</param>
                    /// <param name="t"> Actual age (years) </param>
                    /// <param name="G"> Basal area (m2/ha) </param>
                    public double VCC(double H0, double N, double t, double G = 0)
                    {
                        ThinningclassModel1 a = new ThinningclassModel1();
                        double V = a.thinningDesign(H0, N, G, t, 1, N, 0).Ve;
                        return V;
                    }
                }
                #endregion   

        #endregion

        #region Dynamic Growth Model 3

                #region DLL Info Model 3
                public class DLLInfoModel3
                {
                    // Generic
                    public String Especie = "Betula alba";

                    // Dinamic model
                    //Age limitations
                    public double Maxt = 60;
                    public double Mint = 5;

                    //N limitations
                    public double MaxN = 3500;
                    public double MinN = 400;

                    //Transition equation for Dominant Height
                    public string TransHShortRefH0 = "Tomé  (2001)";
                    public string TransHLongRefH0 = "Tomé, M., (2001) Tabela de produção geral para o pinheiro bravo desenvolvida no âmbito do projecto PAMAF 8165 “Regeneração, Condução e Crescimento do Pinhal Bravo das Regiões Litoral e Interior Centro”. Relatórios técnico-científicos do GIMREF RT9/2001. Centro de Estudos Florestais, Instituto Superior de Agronomia, Lisboa. [in Portuguese] ";
                    public double MaxH0 = 30;
                    public double MinH0 = 5;
                    //
                    //Transition equation for Basal Area
                    public string TransHShortRefG = "Dieguez-Aranda et al. (2009)";
                    public string TransHLongRefG = "Diéguez-Aranda U., Rojo-Alboreca A., Castedo-Dorado F., Álvarez-González J.G., Barrio-Anta M., Crecente-Campo F., González-González J.M., Pérez-Cruzado C., Rodríguez-Soalleiro R., López-Sánchez C.A., Balboa-Murias M.A., Gorgoso-Varela J.J., Sánchez-Rodríguez F. 2009. Herramientas selvícolas para la gestión forestal sostenible en Galicia. Consellería do Medio Rural, Xunta de Galicia. 268 pp + CD-Rom.";
                    public double MaxG = 80;
                    public double MinG = 10;
                    public int InicG = 0; //Inicialication available = 1, unavailable: 0
                    //
                    //Transition equation for Inicialization of Basal Area
                    public string TransHShortRefIniG = "Dieguez-Aranda et al. (2009)";
                    public string TransHLongRefIniG = "Diéguez-Aranda U., Rojo-Alboreca A., Castedo-Dorado F., Álvarez-González J.G., Barrio-Anta M., Crecente-Campo F., González-González J.M., Pérez-Cruzado C., Rodríguez-Soalleiro R., López-Sánchez C.A., Balboa-Murias M.A., Gorgoso-Varela J.J., Sánchez-Rodríguez F. 2009. Herramientas selvícolas para la gestión forestal sostenible en Galicia. Consellería do Medio Rural, Xunta de Galicia. 268 pp + CD-Rom.";

                    //Biomass equation
                    public string TransHShortRefW = "";
                    public string TransHLongRefW = "";

                    //Carbon equation
                    public string TransHShortRefC = "";
                    public string TransHLongRefC = ""; 

                    //
                    public int mort = 1; //0 = none, 1 = Max density equation, 2 = mortality equation
                    //
                    //Transition equation for Density
                    public string TransHShortRefMaxN = "Luis & Fonseca (2004)";
                    public string TransHLongRefMaxN = "Luis, J. F. S., Fonseca, T. (2004) The allometric model in the stand density management of Pinus pinaster Ait. in Portugal. Annals of Forest Science, Springer Verlag 61 (8):807-814.";
                    //
                    //Transition equation for Volume with Cork
                    public string TransHShortRefVCC = "Luis & Fonseca (2004)";
                    public string TransHLongRefVCC = "Luis, J. F. S., Fonseca, T. (2004) The allometric model in the stand density management of Pinus pinaster Ait. in Portugal. Annals of Forest Science, Springer Verlag 61 (8):807-814.";
                    //
                    //Transition equation for Volume Without Cork 
                    public string TransHShortRefVSC;
                    public string TransHLongRefVCS;
                    //

                    //Quality of site idex
                    //values are the inferior limit
                    public double VeryGood = 26;
                    public double Good = 21;
                    public double Moderate = 16;
                    public double Low = 11;
                    public double AgeRefSiteIndex = 40;
                    public double MaxQuality = 28;

                    // Individual tree model
                    //Relation average diameter with cuadratic diameter
                    public string TransHShortRefd_dd = "Fonseca (2004)";
                    public string TransHLongRefd_dd = "Fonseca, T., (2004) Modelação do crescimento, mortalidade e distribuição diamétrica, do pinhal bravo no Vale do Tâmega. University of Trás-os-Montes e Alto Douro, PhD Thesis, Vila Real, Portugal, pp. 248. ";
                    //
                    //Relation diameter with height
                    public string TransHShortRefd_h = "Almeida (1999)";
                    public string TransHLongRefd_h = "Almeida, L.F.R. (1999) Comparação de metodologias para estimação de altura e volume em povoamento s de pinheiro bravo no Vale do Tâmega, Relatório final de estágio. UTAD, Vila Real, 114 pp ";
                    //
                    //Individual volume with cork
                    public string TransHShortvcc = "Nunes et al. (2010)";
                    public string TransHLongvcc = "Nunes, L.; Tomé, J.; Tomé, M. (2010) A system for compatible prediction of total and merchantable volumes allowing for different definitions of tree volume. Canadian Journal of Forest Research. ISSN 1208-6037. 40:4, p. 747-760.";
                    //

                    // Thinning Willson Factor
                    public double FactorwillsonLow = 0.16;
                    public double FactorwillsonModerate = 0.20;
                    public double FactorwillsonModerate_high = 0.23;
                    public double FactorwillsonHigh = 0.28;

                }
                #endregion

                #region Dinamic Growth Model Model 3
                /// <summary> Dinamic growth model for Model1</summary>
                public class GrowthEquationsModel3
                {
                    //Modified for your region only the equation

                    /// <summary> TransH: Transition H0 equation</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="t1"> Actual age (years) </param>
                    /// <param name="t2"> Age to the future(years) </param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public double Ht1_t2(double H0, double N, double G, double t1, double t2)
                    {
                        //Equation
                        return 69 * Math.Pow((H0 / 69), Math.Pow((t1 / t2), 0.458203));
                    }

                    /// <summary> InicG: Initialized Basal Area (m2/ha)</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="t1"> Actual age (years) </param>
                    /// <param name="t2"> Age to the future(years) </param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public double InicG(double H0, double N, double G, double t1, double t2)
                    {
                        //Equation
                        double X0 = (4.363) * Math.Pow(H0_tRef(H0, t1, 20, N, G).H1, 0.07383);
                        double result_G = Math.Exp(X0) * Math.Exp(-(-167.5 + (999.1) / X0) * Math.Pow(t1, -0.8936));
                        return result_G;
                    }

                    /// <summary> G1: Simulate the Basal Area in an age in the future</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="t1"> Actual age (years) </param>
                    /// <param name="t2"> Age to the future(years) </param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public double Gt1_t2(double H0, double N, double G, double t1, double t2)
                    {
                        //Equation
                        double X0 = (Math.Pow(t1, -0.8936) / 2) * (-167.5 + Math.Pow(t1, 0.8936) * Math.Log(G) + Math.Sqrt(4 * (999.1) * Math.Pow(t1, 0.8936) + Math.Pow(167.5 - Math.Pow(t1, 0.8936) * Math.Log(G), 2)));
                        double result_G = Math.Exp(X0) * Math.Exp(-(-167.5 + (999.1) / X0) * Math.Pow(t2, -0.8936));
                        return result_G;
                    }

                    /// <summary> Nmax: alometric model, Max density</summary>
                    /// <param name="N"> Density </param>
                    /// <param name="G"> Basal Area </param>m>
                    public double MaxN(double N, double G)
                    {

                        double dg = Math.Sqrt((4 * G) / (Math.PI * N)) * 100;

                        double Result_N = Math.Exp(13.123 - 1.897 * Math.Log(dg));
                        return Result_N;
                    }

                    /// <summary> Mortality equation</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="t1"> Actual age (years) </param>
                    /// <param name="t2"> Age to the future(years) </param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>m>
                    public double Nt1_t2(double H0, double N, double G, double t1, double t2)
                    {
                        //insert equation of mortality

                        return N;
                    }

                    /// <summary> VCC: Volume with cork (m3/ha)</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public double VCC(double H0, double N, double G)
                    {
                        //Equation
                        double dg = Math.Sqrt((4 * G) / (Math.PI * N)) * 100;
                        double V = 0.063 * Math.Pow(dg, 2.096) * Math.Pow(H0, 0.668) * Math.Pow(N / 1000, 0.978);
                        return V;
                    }

                    /// <summary> W: Total biomass weight with cork (tons) </summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public double W(double H0, double N, double G)
                    {
                        //Equation of Ulises
                        double dg = Math.Sqrt((4 * G) / (Math.PI * N)) * 100;
                        double w = 0.0003390 * Math.Pow(dg, 1.284) * Math.Pow(H0, 1.465) * Math.Pow(N, 0.7277);
                        return w;
                    }

                    // Carbon factor 
                    public double C(double W)
                    {
                        //Equation Dieguez-Aranda 2009
                        return W * 0.479;
                    }

                    //Non modified
                    /// <summary> H1: Dominant height (m) at t2</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="t1"> Actual age (years) </param>
                    /// <param name="t2"> Age to the future(years) </param>
                    /// <param name="N"> Initial density </param>
                    /// <param name="G"> Initial Basal Area </param>
                    public SiteClass H0_tRef(double H0, double t1, double t2, double N, double G)
                    {
                        DLLInfoModel1 info = new DLLInfoModel1();
                        SiteClass SI = new SiteClass();
                        if (t2 == 0)
                        {
                            t2 = info.AgeRefSiteIndex;
                        }
                        SI.H1 = Ht1_t2(H0, N, G, t1, t2);
                        double H2 = Ht1_t2(H0, N, G, t1, info.AgeRefSiteIndex);

                        if (H2 > info.VeryGood)
                        {
                            SI.Quality = "Very good";
                        }
                        else if (H2 > info.Good)
                        {
                            SI.Quality = "Good";
                        }
                        else if (H2 > info.Moderate)
                        {
                            SI.Quality = "Moderate";
                        }
                        else if (H2 > info.Low)
                        {
                            SI.Quality = "Low";
                        }
                        else
                        {
                            SI.Quality = "Very low";
                        }

                        return SI;
                    }

                    /// <summary> VCC: Simulate the volume with cork (m3/ha) to an age in future</summary>
                    /// <param name="H0"> Dominant height (m).</param>
                    /// <param name="N"> Number of tree per hectare (ud/ha)</param>
                    /// <param name="I"> Dummy variable (I) is equal to 0 for Pinus pinaster coast variety and 1 for interior variety.</param>
                    /// <param name="t"> Actual age (years) </param>
                    /// <param name="G"> Basal area (m2/ha) </param>
                    public double VCC(double H0, double N, double t, double G = 0)
                    {
                        ThinningclassModel1 a = new ThinningclassModel1();
                        double V = a.thinningDesign(H0, N, G, t, 1, N, 0).Ve;
                        return V;
                    }
                }
                #endregion   
        #endregion

        #region Individual tree equations Model1
        /// <summary> thinningClass: Thinning design class model</summary>
        public class ThinningclassModel1
        {
            //modified for your region only the equation

            /// <summary> Avdg: relation average d - quadratic diameter</summary>
            /// <param name="dg"> Cuadratic diameter (cm) </param>
            public double Avdg(double dg)
            {
                //Equation
                double result_dg = dg * (1 - Math.Exp(-1.1656 * Math.Pow(dg, 0.4078)));
                return result_dg;
            }

            /// <summary> H2: relation d - H</summary>
            /// <param name="H0"> Dominant height (m).</param>
            /// <param name="N"> Mass Density (trees/ha) </param>
            /// <param name="d"> Diameter (cm) </param>
            /// <param name="d0"> Dominant diameter (cm) </param>
            ///   <param name="t"> Actual age </param>
            public double H(double H0, double d, double d0, double N, double t)
            {
                //Equation
                double h = H0 * Math.Pow((d / d0), (0.09 + 0.04 * H0 - 0.049 * (N / 1000 + 0.162 * t)));
                //double b0 = -5.76514;
                //double b1 = -0.24790;
                //double b2 = 1.49714;
                //double h = (1.3 + (H0 - 1.3) * Math.Exp((b0 + b1 * H0 + b2 * (N / 1000)) * ((1 / d) - (1 / d0))));
                
                return h;
            }

            /// <summary> vcc: individual volume with cork (m3/tree)</summary>
            /// <param name="d"> individual diameter (cm) </param>
            /// <param name="d0"> individual height (cm) </param>
            public double vcc(double d,double h)
            {
                //Equation
                return 0.000031 * Math.Pow(d, 1.902054) * Math.Pow(h - 0.15, 1.062496) + 0.00003 * Math.Pow(d, 2.05722) * Math.Pow(h - 0.15, 0.496504) + 0.000008 * Math.Pow(d, 2.212386) * Math.Pow(h - 0.15, -0.06949) + 0.000098 * Math.Pow(d, 1.986915) * Math.Pow(0.15, 0.937036);
            }

            //Non modified
            /// <summary> thinningDesign: </summary>
            /// <param name="H0"> Dominant height (m).</param>
            /// <param name="N"> Mass Density (trees/ha) </param>
            /// <param name="G"> Basal Area (m2/ha) </param>
            /// <param name="t"> Age (years) </param>
            ///  <param name="CD_range"> Range od diametral classes </param>
            /// <param name="lowerthinning"> Number of trees to extract usen lower thinning (trees/ ha) </param>
            ///   <param name="systhinnig"> Number of trees to extract usen systematic thinning (trees/ ha) </param>
            public Thinning thinningDesign(double H0, double N, double G, double t, double CD_range = 1, double lowerthinning = 0, double systhinnig = 0)
            {
                Thinning newmodel = new Thinning();
                double dH0 = H0;
                double dg = Math.Sqrt((Convert.ToDouble(G * 4) / (Math.PI * N))) * 100;
                double avgd = Avdg(dg);
                double c = C(dg, avgd, 0.0001);
                double b = avgd / gamma(1 + 1 / c);
                double Gextracted = 0;
                double Nextracted = 0;
                double cuttingdiameter = 0;
                double VExtracted = 0;
                //dominant diameter
                double dn = 0;
                for (int i = 1; i <= 100; i++)
                {
                    dn = dn + (Math.Pow(-1 * Math.Log(i / N), (1 / c)) * b)/100;
                }
                double[] actualdistribution = new double[100];
                double[] hi = new double[100];
                double[] VActualDistribution = new double[100];
                double avgh = 0; 
                //actual N distribution
                for (int i = 1; i < 100; i++)
                {
                    //if (i == 0)
                    //{
                    //    actualdistribution[1] = Math.Round(N * CD_range * F((i * CD_range + CD_range / 2) - 0.01, b, c) - F(0, b, c));
                    //}
                    //if (i == 1)
                    //{
                    //    actualdistribution[1] = actualdistribution[1] + Math.Round(N * CD_range * F((i * CD_range + CD_range / 2) - 0.01, b, c) - F(i * CD_range - CD_range / 2, b, c));
                    //}
                    //if (i > 1)
                    //{
                    //    actualdistribution[i] = Math.Round(N * CD_range * F((i * CD_range + CD_range / 2) - 0.01, b, c) - F(i * CD_range - CD_range / 2, b, c));
                    //}
                    actualdistribution[i] = Math.Round(N * CD_range * F((i * CD_range + CD_range / 2) - 0.01, b, c) - F(i * CD_range - CD_range / 2, b, c));
                    hi[i] = H(dH0, CD_range * i, dn, N, t);
                    avgh = avgh + hi[i] * actualdistribution[i]; 
                    VActualDistribution[i] = vcc(CD_range * i, hi[i]) * actualdistribution[i];
                }
                //clara sistematica
                double[] SYSthining = new double[100];
                double[] VieSystematicThinning = new double[100];
                double[] Nie = new double[100];
                double factor = 0;
                if (systhinnig >= N)
                {
                    factor = 1;
                }
                else
                {
                    factor = systhinnig / N;
                }
                for (int i = 0; i < 100; i++)
                {
                    SYSthining[i] = actualdistribution[i] * factor;
                    Gextracted = Gextracted + Math.PI * Math.Pow(((CD_range * i) / 200), 2) * SYSthining[i];
                    Nextracted = Nextracted + SYSthining[i];
                    double h = H(dH0, CD_range * i, dn, N, t);
                    if (SYSthining[i] != 0)
                    {
                        double v = vcc(CD_range * i, h);
                        VExtracted = VExtracted + v * SYSthining[i];
                        VieSystematicThinning[i] = v * SYSthining[i];
                        Nie[i] = SYSthining[i]; 
                    }
                }
                //clara por lo bajo
                double[] thining = new double[100];
                double[] VieLowerThinning = new double[100];
                double cutpercentage = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (lowerthinning > (actualdistribution[i] - thining[i]))
                    {
                        thining[i] = actualdistribution[i] - SYSthining[i];
                        lowerthinning = lowerthinning - (actualdistribution[i] - SYSthining[i]);
                        Gextracted = Gextracted + Math.PI * Math.Pow(((CD_range * i) / 200), 2) * thining[i];
                        Nextracted = Nextracted + thining[i];
                        double h = H(dH0, CD_range * i, dn, N, t);
                        if (thining[i] != 0)
                        {
                            double v = vcc(CD_range * i, h); 
                            VExtracted = VExtracted + v * thining[i];
                            VieLowerThinning[i] = v * thining[i];
                            Nie[i] = Nie[i] + thining[i];
                        }
                    }
                    else if (lowerthinning != 0)
                    {
                        thining[i] = lowerthinning;
                        lowerthinning = 0;
                        Gextracted = Gextracted + Math.PI * Math.Pow(((CD_range * i) / 200), 2) * thining[i];
                        Nextracted = Nextracted + thining[i];
                        cuttingdiameter = i * CD_range;
                        cutpercentage = thining[i];
                        double h = H(dH0, CD_range * i, dn, N, t);
                        if (thining[i] != 0)
                        {
                            double v = vcc(CD_range * i, h);
                            VExtracted = VExtracted + v * thining[i];
                            VieLowerThinning[i] = v * thining[i];
                            Nie[i] = Nie[i] + thining[i];
                        }
                    }
                    else
                    {
                        thining[i] = 0;
                    }
                }

                newmodel.dg = dg;
                newmodel.avd = avgd;
                newmodel.weibullC = c;
                newmodel.weibullB = avgd / gamma(1 + 1 / c);
                newmodel.Ne = Nextracted;
                newmodel.Ve = VExtracted;
                newmodel.Ge = Gextracted;
                newmodel.ActualDistribution = actualdistribution;
                newmodel.NieLowerThinning = thining;
                newmodel.NieSystematicThinning = SYSthining;
                newmodel.lowerthinningInterval = "(" + cuttingdiameter + ";" + (cuttingdiameter + CD_range) + ")";
                newmodel.lowerthinningIntervalN = Math.Round(cutpercentage);
                newmodel.VActualDistribution = VActualDistribution;
                newmodel.VieLowerThinning = VieLowerThinning;
                newmodel.VieSystematicThinning = VieSystematicThinning;
                newmodel.hi = hi;
                newmodel.Nie = Nie;
                newmodel.avgh = avgh / N;  
                return newmodel;
          }

            /// <summary>C: parameter </summary>
          /// <param name="goal"> goal</param>
          /// <param name="avgd"> average diameter </param>
          /// <param name="error"> error </param>
            public double C(double goal, double avgd, double error) 
            {
                //gama limitada para un valor de c dentro de un intervalo intervalo de (1,10)
                for (double c = 0.001; c < 60/error; c++)
                {
                    double X1 = gamma(1 + 1 / (c * error));
                    double X2 = gamma(1 + 2 / (c * error));
                    double X0 = Math.Sqrt(Math.Pow(avgd, 2) / Math.Pow(X1, 2) * X2);
                    if (goal > X0 - (error/2) && goal < X0 + (error/2)) 
                    {
                        return c*error;
                    }
                }
                return 0;
            }

            /// <summary> F: factor F </summary>
            /// <param name="d"> Factor d</param>
            /// <param name="b"> Factor b </param>
            /// <param name="c"> Factor c </param>
            public double F(double d, double b, double c) 
            {
                return (c / b) * Math.Pow(d / b, c - 1) * Math.Exp(-Math.Pow(d / b, c));
            } 
        }

        #endregion

        #region Individual tree equations Model2
        /// <summary> thinningClass: Thinning design class model</summary>
        public class ThinningclassModel2
        {
            //modified for your region only the equation

            /// <summary> Avdg: relation average d - cuadratic diameter</summary>
            /// <param name="dg"> Cuadratic diameter (cm) </param>
            public double Avdg(double dg)
            {
                //Equation
                double d = dg * (1 - Math.Exp(-11.370 * Math.Pow(dg, ((-0.435 - 0.052 * 1)))));
                return d;
            }

            /// <summary> H2: relation d - H</summary>
            /// <param name="H0"> Dominant height (m).</param>
            /// <param name="N"> Mass Density (trees/ha) </param>
            /// <param name="d"> Diameter (cm) </param>
            /// <param name="d0"> Dominant diameter (cm) </param>
            ///   <param name="t"> Actual age </param>
            public double H(double H0, double d, double d0, double N, double t)
            {
                //Equation
                double h = Math.Exp(-0.210 + 0.623 * Math.Log(d) + 0.730 * Math.Log(H0) - 0.368 * Math.Log(d0));
                return h;
            }

            /// <summary> vcc: individual volume with cork (m3/tree)</summary>
            /// <param name="d"> individual diameter (cm) </param>
            /// <param name="d0"> individual height (cm) </param>
            public double vcc(double d, double h)
            {
                //Equation
                double v = 0.08011 * Math.Pow((Math.Pow(d, 2) * h), 0.922)/1000;
                return v; 
            }

            //Non modified
            /// <summary> thinningDesign: </summary>
            /// <param name="H0"> Dominant height (m).</param>
            /// <param name="N"> Mass Density (trees/ha) </param>
            /// <param name="G"> Basal Area (m2/ha) </param>
            /// <param name="t"> Age (years) </param>
            ///  <param name="CD_range"> Range od diametral classes </param>
            /// <param name="lowerthinning"> Number of trees to extract usen lower thinning (trees/ ha) </param>
            ///   <param name="systhinnig"> Number of trees to extract usen systematic thinning (trees/ ha) </param>
            public Thinning thinningDesign(double H0, double N, double G, double t, double CD_range = 1, double lowerthinning = 0, double systhinnig = 0)
            {
                Thinning newmodel = new Thinning();
                double dH0 = H0;
                double dg = Math.Sqrt((Convert.ToDouble(G * 4) / (Math.PI * N))) * 100;
                double avgd = Avdg(dg);
                double c = C(dg, avgd, 0.0001);
                double b = avgd / gamma(1 + 1 / c);
                double Gextracted = 0;
                double Nextracted = 0;
                double cuttingdiameter = 0;
                double VExtracted = 0;
                //dominant diameter
                double dn = 0;
                for (int i = 1; i <= 100; i++)
                {
                    dn = dn + (Math.Pow(-1 * Math.Log(i / N), (1 / c)) * b) / 100;
                }
                double[] actualdistribution = new double[100];
                double[] hi = new double[100];
                double[] VActualDistribution = new double[100];
                double avgh = 0;
                //actual N distribution
                for (int i = 1; i < 100; i++)
                {
                    //if (i == 0)
                    //{
                    //    actualdistribution[1] = Math.Round(N * CD_range * F((i * CD_range + CD_range / 2) - 0.01, b, c) - F(0, b, c));
                    //}
                    //if (i == 1)
                    //{
                    //    actualdistribution[1] = actualdistribution[1] + Math.Round(N * CD_range * F((i * CD_range + CD_range / 2) - 0.01, b, c) - F(i * CD_range - CD_range / 2, b, c));
                    //}
                    //if (i > 1)
                    //{
                    //    actualdistribution[i] = Math.Round(N * CD_range * F((i * CD_range + CD_range / 2) - 0.01, b, c) - F(i * CD_range - CD_range / 2, b, c));
                    //}
                    actualdistribution[i] = Math.Round(N * CD_range * F((i * CD_range + CD_range / 2) - 0.01, b, c) - F(i * CD_range - CD_range / 2, b, c));
                    hi[i] = H(dH0, CD_range * i, dn, N, t);
                    avgh = avgh + hi[i] * actualdistribution[i];
                    VActualDistribution[i] = vcc(CD_range * i, hi[i]) * actualdistribution[i];
                }
                //clara sistematica
                double[] SYSthining = new double[100];
                double[] VieSystematicThinning = new double[100];
                double[] Nie = new double[100];
                double factor = 0;
                if (systhinnig >= N)
                {
                    factor = 1;
                }
                else
                {
                    factor = systhinnig / N;
                }
                for (int i = 0; i < 100; i++)
                {
                    SYSthining[i] = actualdistribution[i] * factor;
                    Gextracted = Gextracted + Math.PI * Math.Pow(((CD_range * i) / 200), 2) * SYSthining[i];
                    Nextracted = Nextracted + SYSthining[i];
                    double h = H(dH0, CD_range * i, dn, N, t);
                    if (SYSthining[i] != 0)
                    {
                        double v = vcc(CD_range * i, h);
                        VExtracted = VExtracted + v * SYSthining[i];
                        VieSystematicThinning[i] = v * SYSthining[i];
                        Nie[i] = SYSthining[i];
                    }
                }
                //clara por lo bajo
                double[] thining = new double[100];
                double[] VieLowerThinning = new double[100];
                double cutpercentage = 0;
                for (int i = 0; i < 100; i++)
                {
                    if (lowerthinning > (actualdistribution[i] - thining[i]))
                    {
                        thining[i] = actualdistribution[i] - SYSthining[i];
                        lowerthinning = lowerthinning - (actualdistribution[i] - SYSthining[i]);
                        Gextracted = Gextracted + Math.PI * Math.Pow(((CD_range * i) / 200), 2) * thining[i];
                        Nextracted = Nextracted + thining[i];
                        double h = H(dH0, CD_range * i, dn, N, t);
                        if (thining[i] != 0)
                        {
                            double v = vcc(CD_range * i, h);
                            VExtracted = VExtracted + v * thining[i];
                            VieLowerThinning[i] = v * thining[i];
                            Nie[i] = Nie[i] + thining[i];
                        }
                    }
                    else if (lowerthinning != 0)
                    {
                        thining[i] = lowerthinning;
                        lowerthinning = 0;
                        Gextracted = Gextracted + Math.PI * Math.Pow(((CD_range * i) / 200), 2) * thining[i];
                        Nextracted = Nextracted + thining[i];
                        cuttingdiameter = i * CD_range;
                        cutpercentage = thining[i];
                        double h = H(dH0, CD_range * i, dn, N, t);
                        if (thining[i] != 0)
                        {
                            double v = vcc(CD_range * i, h);
                            VExtracted = VExtracted + v * thining[i];
                            VieLowerThinning[i] = v * thining[i];
                            Nie[i] = Nie[i] + thining[i];
                        }
                    }
                    else
                    {
                        thining[i] = 0;
                    }
                }

                newmodel.dg = dg;
                newmodel.avd = avgd;
                newmodel.weibullC = c;
                newmodel.weibullB = avgd / gamma(1 + 1 / c);
                newmodel.Ne = Nextracted;
                newmodel.Ve = VExtracted;
                newmodel.Ge = Gextracted;
                newmodel.ActualDistribution = actualdistribution;
                newmodel.NieLowerThinning = thining;
                newmodel.NieSystematicThinning = SYSthining;
                newmodel.lowerthinningInterval = "(" + cuttingdiameter + ";" + (cuttingdiameter + CD_range) + ")";
                newmodel.lowerthinningIntervalN = Math.Round(cutpercentage);
                newmodel.VActualDistribution = VActualDistribution;
                newmodel.VieLowerThinning = VieLowerThinning;
                newmodel.VieSystematicThinning = VieSystematicThinning;
                newmodel.hi = hi;
                newmodel.Nie = Nie;
                newmodel.avgh = avgh / N;
                return newmodel;
            }

            /// <summary>C: parameter </summary>
            /// <param name="goal"> goal</param>
            /// <param name="avgd"> average diameter </param>
            /// <param name="error"> error </param>
            public double C(double goal, double avgd, double error)
            {
                //gama limitada para un valor de c dentro de un intervalo intervalo de (1,10)
                for (double c = 0.001; c < 400 / error; c++)
                {
                    double X1 = gamma(1 + 1 / (c * error));
                    double X2 = gamma(1 + 2 / (c * error));
                    double X0 = Math.Sqrt(Math.Pow(avgd, 2) / Math.Pow(X1, 2) * X2);
                    if (goal > X0 - (error / 2) && goal < X0 + (error / 2))
                    {
                        return c * error;
                    }
                }
                return 0;
            }

            /// <summary> F: factor F </summary>
            /// <param name="d"> Factor d</param>
            /// <param name="b"> Factor b </param>
            /// <param name="c"> Factor c </param>
            public double F(double d, double b, double c)
            {
                return (c / b) * Math.Pow(d / b, c - 1) * Math.Exp(-Math.Pow(d / b, c));
            }
        }

        #endregion

        #region Individual tree equations Model3
        /// <summary> thinningClass: Thinning design class model</summary>
        public class ThinningclassModel3
        {
            //modified for your region only the equation

            /// <summary> Avdg: relation average d - cuadratic diameter</summary>
            /// <param name="dg"> Cuadratic diameter (cm) </param>
            public double Avdg(double dg)
            {
                //Equation
                return dg * (1 - Math.Exp(-1.1656 * Math.Pow(dg, 0.4078)));
            }

            /// <summary> H2: relation d - H</summary>
            /// <param name="H0"> Dominant height (m).</param>
            /// <param name="N"> Mass Density (trees/ha) </param>
            /// <param name="d"> Diameter (cm) </param>
            /// <param name="d0"> Dominant diameter (cm) </param>
            ///   <param name="t"> Actual age </param>
            public double H(double H0, double d, double d0, double N, double t)
            {
                //Equation
                double h = H0 * Math.Pow((d0 / d), (0.09 + 0.04 * H0 - 0.049 * (N / 1000 + 1.62 * t)));
                return h;
            }

            /// <summary> vcc: individual volume with cork (m3/tree)</summary>
            /// <param name="d"> individual diameter (cm) </param>
            /// <param name="d0"> individual height (cm) </param>
            public double vcc(double d, double h)
            {
                //Equation
                return 0.000031 * Math.Pow(d, 1.902054) * Math.Pow(h - 0.15, 1.062496) + 0.00003 * Math.Pow(d, 2.05722) * Math.Pow(h - 0.15, 0.496504) + 0.000008 * Math.Pow(d, 2.212386) * Math.Pow(h - 0.15, -0.06949) + 0.000098 * Math.Pow(d, 1.986915) * Math.Pow(0.15, 0.937036);
            }

            //Non modified
            /// <summary> thinningDesign: </summary>
            /// <param name="H0"> Dominant height (m).</param>
            /// <param name="N"> Mass Density (trees/ha) </param>
            /// <param name="G"> Basal Area (m2/ha) </param>
            /// <param name="t"> Age (years) </param>
            ///  <param name="CD_range"> Range od diametral classes </param>
            /// <param name="lowerthinning"> Number of trees to extract usen lower thinning (trees/ ha) </param>
            ///   <param name="systhinnig"> Number of trees to extract usen systematic thinning (trees/ ha) </param>
            public Thinning thinningDesign(double H0, double N, double G, double t, double CD_range = 1, double lowerthinning = 0, double systhinnig = 0)
            {
                Thinning newmodel = new Thinning();
                double dH0 = H0;
                double dg = Math.Sqrt((Convert.ToDouble(G * 4) / (Math.PI * N))) * 100;
                double avgd = Avdg(dg);
                double c = C(dg, avgd, 0.00001);
                double b = avgd / gamma(1 + 1 / c);
                double Gextracted = 0;
                double Nextracted = 0;
                double cuttingdiameter = 0;
                double VExtracted = 0;

                //dominant diameter
                double dn = 0;
                for (int i = 1; i <= 100; i++)
                {
                    dn = dn + (Math.Pow(-1 * Math.Log(i / N), (1 / c)) * b) / 100;
                }

                double[] actualdistribution = new double[100];
                //actual N distribution
                for (int i = 1; i < 100; i++)
                {
                    actualdistribution[i] = Math.Round(N * CD_range * F(i * CD_range + CD_range / 2, b, c) - F(i * CD_range - CD_range / 2, b, c));
                }

                //clara sistematica
                double[] SYSthining = new double[100];
                double factor = 0;
                if (systhinnig >= N)
                {
                    factor = 1;
                }
                else
                {
                    factor = systhinnig / N;
                }

                for (int i = 1; i < 100; i++)
                {
                    SYSthining[i] = actualdistribution[i] * factor;
                    Gextracted = Gextracted + Math.PI * Math.Pow(((CD_range * i) / 200), 2) * SYSthining[i];
                    Nextracted = Nextracted + SYSthining[i];
                    double h = H(dH0, CD_range * i, dn, N, t);
                    if (SYSthining[i] != 0)
                    {
                        double v = vcc(CD_range * i, h);
                        VExtracted = VExtracted + v * SYSthining[i];
                    }
                }

                //clara por lo bajo
                double[] thining = new double[100];
                double cutpercentage = 0;
                for (int i = 1; i < 100; i++)
                {
                    if (lowerthinning > (actualdistribution[i] - thining[i]))
                    {
                        thining[i] = actualdistribution[i] - SYSthining[i];
                        lowerthinning = lowerthinning - (actualdistribution[i] - SYSthining[i]);
                        Gextracted = Gextracted + Math.PI * Math.Pow(((CD_range * i) / 200), 2) * thining[i];
                        Nextracted = Nextracted + thining[i];
                        double h = H(dH0, CD_range * i, dn, N, t);
                        if (thining[i] != 0)
                        {
                            double v = vcc(CD_range * i, h);
                            VExtracted = VExtracted + v * thining[i];
                        }
                    }
                    else if (lowerthinning != 0)
                    {
                        thining[i] = lowerthinning;
                        lowerthinning = 0;
                        Gextracted = Gextracted + Math.PI * Math.Pow(((CD_range * i) / 200), 2) * thining[i];
                        Nextracted = Nextracted + thining[i];
                        cuttingdiameter = i * CD_range;
                        cutpercentage = thining[i];
                        double h = H(dH0, CD_range * i, dn, N, t);
                        if (thining[i] != 0)
                        {
                            double v = vcc(CD_range * i, h);
                            VExtracted = VExtracted + v * thining[i];
                        }
                    }
                    else
                    {
                        thining[i] = 0;
                    }
                }

                newmodel.dg = dg;
                newmodel.avd = avgd;
                newmodel.weibullC = c;
                newmodel.weibullB = avgd / gamma(1 + 1 / c);
                newmodel.Ne = Nextracted;
                newmodel.Ve = VExtracted;
                newmodel.Ge = Gextracted;
                newmodel.ActualDistribution = actualdistribution;
                newmodel.NieLowerThinning = thining;
                newmodel.NieSystematicThinning = SYSthining;
                newmodel.lowerthinningInterval = "(" + cuttingdiameter + ";" + (cuttingdiameter + CD_range) + ")";
                newmodel.lowerthinningIntervalN = Math.Round(cutpercentage);
                return newmodel;
            }

            /// <summary>C: parameter </summary>
            /// <param name="goal"> goal</param>
            /// <param name="avgd"> average diameter </param>
            /// <param name="error"> error </param>
            public double C(double goal, double avgd, double error)
            {
                //gama limitada para un valor de c dentro de un intervalo intervalo de (1,10)
                for (double c = 0.001; c < 60 / error; c++)
                {
                    double X1 = gamma(1 + 1 / (c * error));
                    double X2 = gamma(1 + 2 / (c * error));
                    double X0 = Math.Sqrt(Math.Pow(avgd, 2) / Math.Pow(X1, 2) * X2);
                    if (goal > X0 - (error / 2) && goal < X0 + (error / 2))
                    {
                        return c * error;
                    }
                }
                return 0;
            }

            /// <summary> F: factor F </summary>
            /// <param name="d"> Factor d</param>
            /// <param name="b"> Factor b </param>
            /// <param name="c"> Factor c </param>
            public double F(double d, double b, double c)
            {
                return (c / b) * Math.Pow(d / b, c - 1) * Math.Exp(-Math.Pow(d / b, c));
            }
        }

        #endregion

        //Non modified
        #region Generic Process Classes

        //Thinning Class model
        /// <summary> Thinning: Thinning Class model</summary>
        
        
        
        
        //Site class model
        /// <summary> SiteClass: Site class model</summary>
        public class SiteClass
        {
            public double H1;
            public string Quality;
        }

        //Thinning Class model
        /// <summary> Thinning: Thinning Class model</summary>
        public class Thinning
        {
            public double Ne;
            public double Ve;
            public double Ge;
            public double dg;
            public double avd;
            public double avgh;
            public double[] ActualDistribution;
            public double[] NieSystematicThinning;
            public double[] NieLowerThinning;
            public double[] VActualDistribution;
            public double[] VieSystematicThinning;
            public double[] VieLowerThinning;
            public double[] hi;
            public double[] Nie;
            public double weibullC;
            public double weibullB;
            public string lowerthinningInterval;
            public double lowerthinningIntervalN;
        }

        //Thinning applications model
        /// <summary> ThinningApp: Thinning applications model</summary>
        public class ThinningApp
        {
            public double t;
            public double SysNe;
            public double LowNe;
        }

        //Thinning applications list model
        /// <summary> Thinningmanagement: Thinning applications list model</summary>
        public class Thinningmanagement
        {
            public List<ThinningApp> managementlistapp;
        }
        #endregion

        #region Weibull parametrize

        // solver for wheibull distribution 
        /// <summary>
        /// Returns the gamma function of the specified number.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double gamma(double x)
        {
            double[] P = {
						 1.60119522476751861407E-4,
						 1.19135147006586384913E-3,
						 1.04213797561761569935E-2,
						 4.76367800457137231464E-2,
						 2.07448227648435975150E-1,
						 4.94214826801497100753E-1,
						 9.99999999999999996796E-1
					 };
            double[] Q = {
						 -2.31581873324120129819E-5,
						 5.39605580493303397842E-4,
						 -4.45641913851797240494E-3,
						 1.18139785222060435552E-2,
						 3.58236398605498653373E-2,
						 -2.34591795718243348568E-1,
						 7.14304917030273074085E-2,
						 1.00000000000000000320E0
					 };

            double p, z;

            double q = Math.Abs(x);

            if (q > 33.0)
            {
                if (x < 0.0)
                {
                    p = Math.Floor(q);
                    if (p == q) throw new ArithmeticException("gamma: overflow");
                    //int i = (int)p;
                    z = q - p;
                    if (z > 0.5)
                    {
                        p += 1.0;
                        z = q - p;
                    }
                    z = q * Math.Sin(Math.PI * z);
                    if (z == 0.0) throw new ArithmeticException("gamma: overflow");
                    z = Math.Abs(z);
                    z = Math.PI / (z * stirf(q));

                    return -z;
                }
                else
                {
                    return stirf(x);
                }
            }

            z = 1.0;
            while (x >= 3.0)
            {
                x -= 1.0;
                z *= x;
            }

            while (x < 0.0)
            {
                if (x == 0.0)
                {
                    throw new ArithmeticException("gamma: singular");
                }
                else if (x > -1.0E-9)
                {
                    return (z / ((1.0 + 0.5772156649015329 * x) * x));
                }
                z /= x;
                x += 1.0;
            }

            while (x < 2.0)
            {
                if (x == 0.0)
                {
                    throw new ArithmeticException("gamma: singular");
                }
                else if (x < 1.0E-9)
                {
                    return (z / ((1.0 + 0.5772156649015329 * x) * x));
                }
                z /= x;
                x += 1.0;
            }

            if ((x == 2.0) || (x == 3.0)) return z;

            x -= 2.0;
            p = polevl(x, P, 6);
            q = polevl(x, Q, 7);
            return z * p / q;

        }

        /// <summary>
        /// Return the gamma function computed by Stirling's formula.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static double stirf(double x)
        {
            double[] STIR = {
							7.87311395793093628397E-4,
							-2.29549961613378126380E-4,
							-2.68132617805781232825E-3,
							3.47222221605458667310E-3,
							8.33333333333482257126E-2,
		};
            double MAXSTIR = 143.01608;

            double w = 1.0 / x;
            double y = Math.Exp(x);

            w = 1.0 + w * polevl(w, STIR, 4);

            if (x > MAXSTIR)
            {
                /* Avoid overflow in Math.Pow() */
                double v = Math.Pow(x, 0.5 * x - 0.25);
                y = v * (v / y);
            }
            else
            {
                y = Math.Pow(x, x - 0.5) / y;
            }
            y = 2.50662827463100050242 * y * w;
            return y;
        }

        /// <summary>
        /// Evaluates polynomial of degree N
        /// </summary>
        /// <param name="x"></param>
        /// <param name="coef"></param>
        /// <param name="N"></param>
        /// <returns></returns>
        private static double polevl(double x, double[] coef, int N)
        {
            double ans;

            ans = coef[0];

            for (int i = 1; i <= N; i++)
            {
                ans = ans * x + coef[i];
            }
            return ans;
        }

        #endregion
    }
}

