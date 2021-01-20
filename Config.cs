using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GenProgram_v2._0
{
    public class Config
    {

        #region GeneralSystemInfo
        private int rateRefresh;
        public int CellCount { get; set; }              // Количество ячеек
        public float EnergyScale { get; set; }          // Ориентир для цветового спектра
        public float WindowScale { get; set; }          // Мастшаб ячеек поля
        public int RateRefresh                          // Частота обновления поля
        {
            get { return rateRefresh; }
            set
            {
                switch (value)
                {
                    case 0:
                        rateRefresh = 60;
                        break;
                    case 1:
                        rateRefresh = 30;
                        break;
                    case 2:
                        rateRefresh = 15;
                        break;
                    case 3:
                        rateRefresh = 10;
                        break;
                    case 4:
                        rateRefresh = 5;
                        break;
                    case 5:
                        rateRefresh = 2;
                        break;
                    case 6:
                        rateRefresh = 1;
                        break;
                    default:
                        rateRefresh = 60;
                        break;
                }
            }
        }                       
        #endregion
        #region SystemState
        public float EnergyCapacity { get; set; }       // Объем энергии системы
        public float EnergyMaxCell { get; set; }        // Максимальный энергозапас клетки поля
        public float EnergyPerCell { get; set; }        // Энергия в каждой ячейки(при старте)
        #endregion
        #region SystemEnergyMoveState
        public bool EnergyMoveUp { get; set; }          //Смещение энергии вверх
        public bool EnergyMoveDown { get; set; }        //Смещение энергии вниз
        public bool EnergyMoveRight { get; set; }       //Смещение энергии вправо
        public bool EnergyMoveLeft { get; set; }        //Смещение энергии влево
        public bool EnergyMoveCenter { get; set; }      //Смещение энергии к центру
        #endregion
        #region EntityState
        public int PopSize { get; set; }                // Размер популяции сущностей
        public int PopSizeCurrent { get; set; }         // Размер популяции сущностей(текущий)
        public float EnergyMaxEntity { get; set; }      // Максимальная энергия сущности
        public float EnregyEntityIn { get; set; }       // Поглощение энергии сущностью
        public float EnregyEntityOut { get; set; }      // Выделение энергии сущностью
        public int SpreadEnergySize { get; set; }       // Радиус выделения энергии
        public float ShiftEnergy { get; set; }          // Энергия затрачиваемая сущностью на передвижение
        public float ScaleShiftBorder { get; set; }     // Граница передвижения(для того чтобы сущность передвинулась, энергия между двумя клетками должна отличаться в scaleShiftBorder раз)
        #endregion

        public Config()
        {
            EnergyMoveUp = EnergyMoveDown = EnergyMoveLeft = EnergyMoveRight = EnergyMoveCenter = false;
            RateRefresh = 0;

           // CellCount = 125;
            //PopSize = 1000;

            //EnergyScale = 0.45f;
            //WindowScale = 1f;
            //SpreadEnergySize = 3;
            //ScaleShiftBorder = 50f;
            //EnergyCapacity = 7000;
            //EnergyMaxCell = 100;

            //EnergyMaxCell = 4 * EnergyCapacity / (CellCount * CellCount);
            //EnergyMaxEntity = 2.5f * EnergyPerCell;
            //EnregyEntityIn = EnergyPerCell / 5;
            //EnregyEntityOut = EnergyPerCell / 20;
            //ShiftEnergy = EnergyPerCell * 0.6f;
        }

    }
}
