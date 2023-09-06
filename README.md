A non-empty array A consisting of N integers (may be negative or zero) is given. The product of triplet (P, Q, R) equates to A[P] * A[Q] * A[R] (0 <= P < Q < R < N) 

Produce a solution that will find the maximal value of any possible triplet Q, P, R for the array. 
* Not required to give the values P, Q, R giving a maximal product, but the value of the maximal product possible. 

This solution considers that the maximal product of three will be the product of the three largest array elements.
The solution in O(n) time and O(1) space complexity is written to find the three largest values in the array, noting that
the array elements may not be distinct. 
The product of these three elements is returned. 

