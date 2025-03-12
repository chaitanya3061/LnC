
class Program
{
    static void Main(string[] args)
    {
        int numberOfElements, numberOfQueries;

        Console.WriteLine("Input");
        string[] firstLine = Console.ReadLine().Split();
        numberOfElements = int.Parse(firstLine[0]);
        numberOfQueries = int.Parse(firstLine[1]);

        List<int> elementsArray = new List<int>();
        List<Tuple<int, int>> queries = new List<Tuple<int, int>>();

        string[] elements = Console.ReadLine().Split();
        for (int index = 0; index < numberOfElements; index++)
        {
            elementsArray.Add(int.Parse(elements[index]));
        }

        for (int index = 0; index < numberOfQueries; index++)
        {
            string[] query = Console.ReadLine().Split();
            int leftIndex = int.Parse(query[0]);
            int rightIndex = int.Parse(query[1]);
            queries.Add(Tuple.Create(leftIndex, rightIndex));
        }

        List<int> prefixSum = computePrefixSums(elementsArray);
        processQueries(numberOfQueries, queries, prefixSum);
    }

    static List<int> computePrefixSums(List<int> elementsArray)
    {
        int numberOfElements = elementsArray.Count;
        List<int> prefixSum = new List<int>(new int[numberOfElements + 1]);

        for (int index = 1; index <= numberOfElements; index++)
        {
            prefixSum[index] = prefixSum[index - 1] + elementsArray[index - 1];
        }

        return prefixSum;
    }

    static int calculateSubarrayMean(int leftIndex, int rightIndex, List<int> prefixSum)
    {
        int subarraySum = prefixSum[rightIndex] - prefixSum[leftIndex - 1];
        int elementsInSubarray = rightIndex - leftIndex + 1;
        return subarraySum / elementsInSubarray;
    }

    static void processQueries(int numberOfQueries, List<Tuple<int, int>> queries, List<int> prefixSum)
    {
        Console.WriteLine("Output");

        for (int index = 0; index < numberOfQueries; index++)
        {
            int leftIndex = queries[index].Item1;
            int rightIndex = queries[index].Item2;
            Console.WriteLine(calculateSubarrayMean(leftIndex, rightIndex, prefixSum));
        }
    }
}
