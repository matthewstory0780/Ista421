Homework, ISTA-421
--
Chapter 19, C# Step by Step
--
Discussion Questions
--
1. What is an enumerable collection?

--It is a collection that implements the System.Collectons.IEnumerable interace

2. What properties and methods does the IEnumerable interface contain?

--It contains a single methods called GetEnumerator

3. What properties and methods does the IEnumerator interface contain?

--It contains a single methods called GetEnumerator


4. What values does the MoveNext() method return? What does it do?

--It updates your position in the structure when defining an enumerator. true or false. it is a boolean.

5. What values does the Reset() method return? What does it do?

--Sets the enumerator to its initial position, which is before the first element in the collection.An enumerator remains valid as long as the collection remains unchanged.

6. Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type safety?

--Not type safe, you implement type safety using generics.

7. Why don’t recursive methods retain state when used with data structures like binary trees?

--Because you have a new stack .

8. How do you deﬁne an enumerator?

--An enumerator helps you enumerate (iterate) over a collection of items. A pointer indicating elements in a list.

9. What is an iterator?

--In computer programming, an iterator is an object that enables a programmer to traverse a container, particularly lists. Various types of iterators are often provided via a container's interface. ORDERED SEQUENCE OF VALUES.

10. What does yield do?10. 

--Yield keyword helps us to do custom stateful iteration over .NET collections.
