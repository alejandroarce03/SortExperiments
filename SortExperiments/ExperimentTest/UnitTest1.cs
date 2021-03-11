using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SortExperiments.Model;



namespace ExperimentTest
{
    [TestClass]
    public class UnitTest1
    {
        public int[] arreglo10a1;
        public int[] arreglo10a2;
        public int[] arreglo10a3;

        private Experiment experiment;

        [TestInitialize]
        public void Initialize()
        {
            experiment = new Experiment();
        }
        private void setup1()
        {
            arreglo10a1 = new int[10] { 2, 9, 15, 30, 24, 1, 5, -5, -7, -8 };




        }
        private void setup2()
        {
            arreglo10a2 = new int[100] { 78, 43, 32, 30, 60, 84, 87, 31, 83, 20, 64, 56, 25, 88, 12, 20, 4, 91, 79, 48, 77, 9, 8, 30, 50, 1, 70, 26, 23, 54, 28, 6, 10, 38, 12, 78, 15, 44, 75, 39, 98, 37, 64, 56, 9, 0, 73, 81, 72, 61, 95, 94, 91, 58, 29, 38, 77, 40, 56, 0, 66, 42, 59, 10, 52, 45, 67, 18, 17, 18, 91, 20, 41, 83, 40, 74, 56, 64, 11, 11, 37, 72, 71, 29, 40, 40, 78, 88, 38, 43, 17, 91, 35, 33, 15, 40, 41, 50, 99, 42 };
        }

        private void setup3()
        {
            arreglo10a3 = new int[1000];

            arreglo10a3 = CreateArray(1000);

        }
        public int[] CreateArray(long size)
        {

            Random rd = new Random();
            int[] array = new int[size];
            int randomNumber = 0;
            for (long i = 0; i < size; i++)
            {
                randomNumber = rd.Next();
                array[i] = randomNumber;
            }
            return array;
        }



        [TestMethod]
        public void TestMergeSort()
        {
            setup1();
            setup2();
            setup3();

            int[] respuesta1 = { -8, -7, -5, 1, 2, 5, 9, 15, 24, 30 };
            int[] respuesta2 = { 0, 0, 1, 4, 6, 8, 9, 9, 10, 10, 11, 11, 12, 12, 15, 15, 17, 17, 18, 18, 20, 20, 20, 23, 25, 26, 28, 29, 29, 30, 30, 31, 32, 33, 35, 37, 37, 38, 38, 38, 39, 40, 40, 40, 40, 40, 41, 41, 42, 42, 43, 43, 44, 45, 48, 50, 50, 52, 54, 56, 56, 56, 56, 58, 59, 60, 61, 64, 64, 64, 66, 67, 70, 71, 72, 72, 73, 74, 75, 77, 77, 78, 78, 78, 79, 81, 83, 83, 84, 87, 88, 88, 91, 91, 91, 91, 94, 95, 98, 99 };
            int[] copia3 = arreglo10a3;
            Array.Sort(copia3);



            arreglo10a1 = experiment.MergeSort(arreglo10a1);
            //experiment
            arreglo10a2 = experiment.MergeSort(arreglo10a2);
            arreglo10a3 = experiment.MergeSort(arreglo10a3);




            Console.WriteLine("Hola");
            CollectionAssert.AreEqual(respuesta1, arreglo10a1);
            CollectionAssert.AreEqual(respuesta2, arreglo10a2);
            CollectionAssert.AreEqual(copia3, arreglo10a3);




            //Assert.AreEqual(respuesta2s, metodo2);
            //Assert.AreEqual(respuesta3s,metodo3);

        }

        [TestMethod]
        public void TestInsertionSort()
        {
            setup1();
            setup2();
            setup3();

            int[] respuesta1 = { -8, -7, -5, 1, 2, 5, 9, 15, 24, 30 };
            int[] respuesta2 = { 0, 0, 1, 4, 6, 8, 9, 9, 10, 10, 11, 11, 12, 12, 15, 15, 17, 17, 18, 18, 20, 20, 20, 23, 25, 26, 28, 29, 29, 30, 30, 31, 32, 33, 35, 37, 37, 38, 38, 38, 39, 40, 40, 40, 40, 40, 41, 41, 42, 42, 43, 43, 44, 45, 48, 50, 50, 52, 54, 56, 56, 56, 56, 58, 59, 60, 61, 64, 64, 64, 66, 67, 70, 71, 72, 72, 73, 74, 75, 77, 77, 78, 78, 78, 79, 81, 83, 83, 84, 87, 88, 88, 91, 91, 91, 91, 94, 95, 98, 99 };
            int[] copia3 = arreglo10a3;
            Array.Sort(copia3);



            arreglo10a1 = experiment.InsertionSort(arreglo10a1);
            //experiment
            arreglo10a2 = experiment.InsertionSort(arreglo10a2);
            arreglo10a3 = experiment.InsertionSort(arreglo10a3);




            Console.WriteLine("Hola");
            CollectionAssert.AreEqual(respuesta1, arreglo10a1);
            CollectionAssert.AreEqual(respuesta2, arreglo10a2);
            CollectionAssert.AreEqual(copia3, arreglo10a3);

        }

    }
}
