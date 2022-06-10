using System.Collections;
namespace BinarySearchTree_Day15
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Display();
            binarySearch.GetSize();
        }
    }
}