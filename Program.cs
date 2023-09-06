// Top level statements 
// Test the solution 
int[] arr = {-3, 1, 2, -2, 5, 6};
Console.WriteLine($"Test result: {MaximalProduct(arr)}");

public static partial class Program {
    /// <summary>
    /// Given a non empty array of N integers A
    /// The product of triplet P, Q, R is A[P] * A[Q] * A[R]
    /// 0 <= P < Q < R < N
    /// Solutions method finds the value of the maximal possible 
    /// triplet product given array.
    /// This solution considers that the maximal product will be 
    /// the product of the three largest elements 
    /// </summary>
    /// <param name="arr"></param>
    /// <returns></returns>
    public static int MaximalProduct(int[] arr) {
        if (arr.Length < 3)
            throw new ArgumentException("Input array must have three or more elements"); 
        
        if (arr.Length == 3) 
            return (arr[0] * arr[1] * arr[3]); 
        
        // Find the largest three elements 
        int p = arr[0];
        int q = arr[0];
        int r = arr[0];

        // Replace the first, second and third largest elements 
        // p, q, r maintaining order p >= q >= r
        foreach (int n in arr) {
            if (n > p) {
                // Set the new largest element 
                r = q;
                q = p;
                p = n; 
            } else if (n > q) {
                r = q;
                q = n; 
            } else if (n > r) {
                r = n; 
            }
        }

        return (p * q * r);
    }
}