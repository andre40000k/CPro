﻿using CPro_1.Enums;
using CPro_1.Transports;
using CPro_1.Transports.Door;
using CPro_1.Transports.TypeEngine;
using CPro_1.Helper;
using System.ComponentModel;
using System;

namespace CPro_1.ReadFile
{
    public static class Read<T>
    {
        public static async Task<List<T>> GetDate(string path) 
        {
            List<T> transport = await Task.Run(() => ReadFiles(path));            
            return transport;
        }

        public static List<T> ReadFiles(string path) 
        {            
            var transports = new List<T>();

            int type = GetTypeTransport<T>();
            if(type == 0)
            {
                throw new Exception();
            }

            using (var streamReader = new StreamReader(path))
            {
                string line;

                while ((line = streamReader.ReadLine()) != null)
                {
                    var parameters = line.Split(',');
                    transports.Add((T)GetObjects(parameters, type));
                }
            }

            return transports;
        }

        private static int GetTypeTransport<T>()
        {
            
            if(typeof(AutomobileTransport).IsAssignableFrom(typeof(T)))
                return  1;
            else if(typeof(AirTransport).IsAssignableFrom(typeof(T)))
                return 2;
            else if(typeof(RailwayTransport).IsAssignableFrom(typeof(T)))
                return 3;

            return 0;
        }   

        private static object GetObjects(string[] inform, int type)
        {
            switch (type)
            {
                case 1:
                    var transport1 = new AutomobileTransport(new BaseEngine((TypeEngineEnum)Enum.Parse(typeof(TypeEngineEnum), inform[0].ToUpper())),
                        new DoorPosition((OpenCloseEnum)Enum.Parse(typeof(OpenCloseEnum), inform[1])), inform[2])
                            {
                                NameOfTransport = inform[3],
                                WeightAutoTransport = int.Parse(inform[4]),
                                Speed = int.Parse(inform[5]),
                                Passegers = int.Parse(inform[6])
                            };
                    return transport1;
                case 2:
                    var transport2 = new AirTransport(new BaseEngine((TypeEngineEnum)Enum.Parse(typeof(TypeEngineEnum), inform[0].ToUpper())),
                       new DoorPosition((OpenCloseEnum)Enum.Parse(typeof(OpenCloseEnum), inform[1])), inform[2])
                    {
                        NameOfTransport = inform[3],
                        Passegers = int.Parse(inform[4]),
                        Speed = int.Parse(inform[5])
                    };
                    return transport2;
                case 3:
                    var transport3 = new RailwayTransport(new BaseEngine((TypeEngineEnum)Enum.Parse(typeof(TypeEngineEnum), inform[0].ToUpper())),
                       new DoorPosition((OpenCloseEnum)Enum.Parse(typeof(OpenCloseEnum), inform[1])), inform[2])
                    {
                        Crew = int.Parse(inform[3]),
                        NameOfTransport = inform[4],
                        Passegers = int.Parse(inform[5]),
                        NumberOfWagons= int.Parse(inform[6]),
                        Speed = int.Parse(inform[7])

                    };
                    return transport3;
            }

            return null;           
        }
    }
}