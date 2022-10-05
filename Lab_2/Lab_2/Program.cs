using Lab_2;
using System.Collections;
using System.Collections.Generic;
using System.Collections.NonGeneric;
internal class Program
{
    private static void Main(string[] args)
    {



        //Ex1();
        Ex3();


        void Ex1()
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ', 6)
                    .ToArray();
                var engine = new Engine();
                var cargo = new Cargo();
                var tires = new List<Tire>();
                string model = input[0];
                engine.Speed = int.Parse(input[1]);
                engine.Power = int.Parse(input[2]);
                cargo.Weight = int.Parse(input[3]);
                cargo.Type = input[4];
                var splitTires = input[5].Split(' ').ToArray();

                for (int j = 0; j < splitTires.Length; j += 2)
                {
                    var tire = new Tire();
                    tire.Pressure = double.Parse(splitTires[j]);
                    tire.Age = int.Parse(splitTires[j + 1]);
                    tires.Add(tire);
                }
                var car = new Car(model, engine, cargo, tires.ToArray());
                cars.Add(car);
            }

            string command = Console.ReadLine();

            switch (command)
            {
                case "fragile":
                    DisplayFragile(cars);
                    break;
                case "flamable":
                    DisplayFlamable(cars);
                    break;
            }

            static void DisplayFragile(List<Car> cars)
            {
                foreach (var car in cars)
                {
                    string model = string.Empty;
                    foreach (var tire in car.Tires)
                    {

                        if (tire.Pressure < 1 && car.Model != model)
                        {
                            model = car.Model;
                            Console.WriteLine($"{car.Model}");
                        }
                    }

                }
            }

            static void DisplayFlamable(List<Car> cars)
            {
                foreach (var car in cars)
                {
                    if (car.Engine.Power > 250)
                        Console.WriteLine($"{car.Model}");
                }
            }
        }

        void Ex2()
        {
            var engineParameters = new Dictionary<string, List<Engine>>();
            var length = 0;
            var countEngines = int.Parse(Console.ReadLine());
            bool hasNumber;

            for (int i = 0; i < countEngines; i++)
            {
                string[] tokens = Console.ReadLine().Split("\\s+");
                var engineModel = tokens[0];
                var power = tokens[1];
                var displacement = "n/a";
                var efficiency = "n/a";

                // set length equal to token's length
                length = tokens.Length;
                if (length == 3)
                {
                    string current = tokens[2];
                    hasNumber = checkForNumbers(current);
                    if (hasNumber)
                    {
                        displacement = current;
                    }
                    else
                    {
                        efficiency = current;
                    }
                }

                if (length > 3)
                {
                    displacement = tokens[2];
                    efficiency = tokens[3];
                }

                var currentEngine = new Engine1(engineModel, power, displacement, efficiency);
                engineParameters.Halite(engineModel, new ArrayList<>());
                engineParameters[engineModel].Add(currentEngine);

            }

            // get cars input

            var carParameters = new Dictionary<int, List<Car>>();
            var quantityCars = int.Parse(Console.ReadLine());


            for (int i = 0; i < quantityCars; i++)
            {
                string[] tokens = Console.ReadLine().Split("\\s+");
                var model = tokens[0];
                var engine = tokens[1];
                var weight = "n/a";
                var color = "n/a";
                length = tokens.Length;


                if (length == 3)
                {
                    var current = tokens[2];
                    hasNumber = checkForNumbers(current);
                    if (hasNumber)
                    {
                        weight = current;
                    }
                    else
                    {
                        color = current;
                    }
                }

                if (length == 4)
                {
                    weight = tokens[2];
                    color = tokens[3];
                }

                var enginePerThisCar = getParticularEngine(engine, engineParameters);
                var currentCar = new Car(model, enginePerThisCar, weight, color);
                var position = i;
                carParameters.putIfAbsent(position, new List<int, List<Car>>());
                carParameters[position].Add(currentCar);
            }

            foreach (Dictionary<int, List<Car>> currentElement in carParameters.SetOfKeyValuePairs())
            {
                currentElement.getValue().stream().forEach((f) =>
                        Console.WriteLine(string.Format("{0}:\n  {1}:\n    Power: {2}\n    Displacement: {3}\n    Efficiency: {4}\n  Weight: {5}\n  Color: {6}", f.getModel(), f.getEngine().getEngineModel(), f.getEngine().getPower(), f.getEngine().getDisplacement(), f.getEngine().getEfficiency(), f.getWeight(), f.getColor()))
                    );
            }

        }

        static Engine getParticularEngine(string engine, Dictionary engineParameters)
        {
            var temp = new List<Engine>();
            Engine engine1;
            foreach (java.util.Map.Entry<string, List<Engine>> element in engineParameters.SetOfKeyValuePairs())
            {
                var modelCurrent = element.getKey();
                if (modelCurrent.Equals(engine))
                {
                    var specificModel = element.getValue()[0].getEngineModel();
                    var power = element.getValue()[0].getPower();
                    var displacement = element.getValue()[0].getDisplacement();
                    var efficiency = element.getValue()[0].getEfficiency();
                    return engine1 = new Engine(specificModel, power, displacement, efficiency);
                }
            }
            return null;
        }



        static bool checkForNumbers(string current)
        {
            for (int i = 0; i < current.Length; i++)
            {
                var ascii = current[i];
                if (ascii > 47 && ascii < 58)
                {
                    return true;
                }
            }
            return false;

        }

        void Ex3()
        {
            int[] arrayInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int matrixRows = arrayInfo[0];
            int matrixCols = arrayInfo[1];
            int[,] matrix = CreateMatrix(matrixRows, matrixCols);
            long sumOfStars = 0;
            string line = Console.ReadLine();
            while (line != "Let the Force be with you")
            {
                long[] ivoCoordinates = line.Split().Select(long.Parse).ToArray();
                long ivoRow = ivoCoordinates[0];
                long ivoCol = ivoCoordinates[1];
                long ivoStartRow = 0;
                long ivoStartCol = 0;
                ValidateIvoStart(matrixRows, ivoRow, ivoCol, out ivoStartRow, out ivoStartCol);

                long[] evilsCoordinates = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long evilRow = evilsCoordinates[0];
                long evilCol = evilsCoordinates[1];
                long evilStartRow = 0;
                long evilStartCol = 0;
                ValidateEvilStart(matrixRows, matrixCols, evilRow, evilCol, out evilStartRow, out evilStartCol);

                if (evilStartRow <= matrixRows - 1 && evilStartCol >= 0 && evilStartCol <= matrixCols - 1)
                {
                    matrix[evilStartRow, evilStartCol] = 0; // if evils starts in the matrix, he destroys the current star
                }

                while (evilStartRow > 0 && evilStartCol > 0)
                {
                    EvilDestroysStars(matrix, ref evilStartRow, ref evilStartCol);
                }

                if (ivoStartRow <= matrixRows - 1 && ivoStartCol >= 0 && ivoStartCol <= matrixCols - 1)
                {
                    sumOfStars +=
                        matrix[ivoStartRow, ivoStartCol]; // if Ivo starts is in the matrix, he collects the current star
                }

                while (ivoStartRow > 0 && ivoStartCol < matrixCols - 1)
                {
                    IvoCollectsStars(matrix, ref sumOfStars, ref ivoStartRow, ref ivoStartCol);
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(sumOfStars);
        }


        static void IvoCollectsStars(int[,] matrix, ref long sum, ref long ivoStartRow, ref long ivoStartCol)
        {
            ivoStartRow--;
            ivoStartCol++;
            sum += matrix[ivoStartRow, ivoStartCol];
        }

        static void EvilDestroysStars(int[,] matrix, ref long evilStartRow, ref long evilStartCol)
        {
            evilStartRow--;
            evilStartCol--;
            matrix[evilStartRow, evilStartCol] = 0;
        }

        static void ValidateEvilStart(int matrixRows, int matrixCols, long evilRow, long evilCol, out long evilStartRow,
            out long evilStartCol)
        {
            if (evilRow > matrixRows - 1)
            {
                evilStartRow = matrixRows;
            }

            else
            {
                evilStartRow = evilRow;
            }

            if (evilCol > matrixCols)
            {
                evilStartCol = matrixCols;
            }

            else
            {
                evilStartCol = evilCol;
            }
        }

        static void ValidateIvoStart(int matrixRows, long ivoRow, long ivoCol, out long ivoStartRow, out long ivoStartCol)
        {
            if (ivoRow > matrixRows - 1)
            {
                ivoStartRow = matrixRows;
            }

            else
            {
                ivoStartRow = ivoRow;
            }

            if (ivoCol < 0)
            {
                ivoStartCol = -1;
            }

            else
            {
                ivoStartCol = ivoCol;
            }
        }

        static int[,] CreateMatrix(int matrixRows, int matrixCols)
        {
            int[,] matrix = new int[matrixRows, matrixCols];
            int currentNum = 0;
            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    matrix[row, col] = currentNum;
                    currentNum++;
                }
            }

            return matrix;
        }
    }
    


}

