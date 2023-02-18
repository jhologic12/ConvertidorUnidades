using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertidorUnidades
{
    public class ConvertidorService
    {

        public double ConvertidorMasaUnidades(MasaEnum De , MasaEnum A , double cantidad)
        {
            double valorConvertido = 0;


            switch (De)
            {
                case MasaEnum.Miligramo:
                    {

                        switch (A)
                        {
                            
                            case MasaEnum.Gramo:
                                valorConvertido = cantidad/100;
                                break;
                            case MasaEnum.Kilogramo:
                                valorConvertido = cantidad / 1000000;
                                break;
                            default:
                                break;
                        }

                    }
                    break;
                case MasaEnum.Gramo:
                    {
                        switch (A)
                        {

                            case MasaEnum.Miligramo:
                                valorConvertido = cantidad * 1000;
                                break;
                            case MasaEnum.Kilogramo:
                                valorConvertido = cantidad / 1000;
                                break;
                            default:
                                break;
                        }


                    }
                    break;
                case MasaEnum.Kilogramo:
                    {

                        switch (A)
                        {

                            case MasaEnum.Gramo:
                                valorConvertido = cantidad * 1000;
                                break;
                            case MasaEnum.Miligramo:
                                valorConvertido = cantidad * 1000000;
                                break;
                            default:
                                break;
                        }

                    }
                    break;
                default:
                    break;
            }



            return valorConvertido;
        }
    
    
        public double ConvertidorTemperaturaUnidades(TemperaturaEnum De , TemperaturaEnum A , double cantidad)
        {
            double valorConvertido = 0;


            switch (De)
            {
                case TemperaturaEnum.Celsius:
                    {

                        switch (A)
                        {
                           
                            case TemperaturaEnum.Fahrenheit:

                                valorConvertido = (cantidad * 1.8) + 32;
                                break;
                            case TemperaturaEnum.Kelvin:

                                valorConvertido = cantidad + 273.15;
                                break;
                            default:
                                break;
                        }

                    }
                    break;
                case TemperaturaEnum.Fahrenheit:
                    {

                        switch (A)
                        {

                            case TemperaturaEnum.Celsius:
                                valorConvertido = (cantidad - 32) * 1.8;

                                break;
                            case TemperaturaEnum.Kelvin:

                                valorConvertido = (cantidad - 32) * 1.8 + 273.15;
                                break;
                            default:
                                break;
                        }

                    }
                    break;
                case TemperaturaEnum.Kelvin:
                    {
                        switch (A)
                        {

                            case TemperaturaEnum.Celsius:
                                valorConvertido = cantidad - 273.15;
                                break;
                            case TemperaturaEnum.Fahrenheit:
                                valorConvertido = (cantidad - 273.15) * 1.8 + 32;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }

            return valorConvertido;
        }



        public double ConvertidorTiempoUnidades(TiempoEnum De , TiempoEnum A , double cantidad)
        {
            double valorConvertido = 0;

            switch (De)
            {
                case TiempoEnum.MiliSegundos:
                    {

                        switch (A)
                        {
                            
                            case TiempoEnum.Segundos:
                                valorConvertido = cantidad / 1000;

                                break;
                            case TiempoEnum.Minutos:
                                valorConvertido = cantidad / 60000;
                                break;
                            case TiempoEnum.Horas:
                                valorConvertido = cantidad / 3600000;
                                break;
                            default:
                                break;
                        }


                    }
                    break;
                case TiempoEnum.Segundos:
                    {

                        switch (A)
                        {

                            case TiempoEnum.MiliSegundos:
                                valorConvertido = cantidad * 100;
                                break;
                            case TiempoEnum.Minutos:
                                valorConvertido = cantidad /60;
                                break;
                            case TiempoEnum.Horas:
                                valorConvertido = cantidad / 3600;
                                break;
                            default:
                                break;
                        }


                    }
                    break;
                case TiempoEnum.Minutos:
                    {

                        switch (A)
                        {

                            case TiempoEnum.MiliSegundos:
                                valorConvertido = cantidad * 60000;
                                break;
                            case TiempoEnum.Segundos:
                                valorConvertido = cantidad * 60;
                                break;
                            case TiempoEnum.Horas:
                                valorConvertido = cantidad / 60;
                                break;
                            default:
                                break;
                        }

                    }
                    break;
                case TiempoEnum.Horas:
                    {

                        switch (A)
                        {

                            case TiempoEnum.MiliSegundos:
                                valorConvertido = cantidad * 3600000;
                                break;
                            case TiempoEnum.Segundos:
                                valorConvertido = cantidad * 3600;
                                break;
                            case TiempoEnum.Minutos:
                                valorConvertido = cantidad * 60;
                                break;
                            default:
                                break;
                        }

                    }
                    break;
                default:
                    break;
            }

            return valorConvertido;

        }
    
    
    }
}
