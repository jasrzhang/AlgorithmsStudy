
# Heaps 

## *AKA* **Prioritised Queues**

### Features Difer as Queues are:

1. Collection of ***Proiritised*** Objects,
2. **Insertion**: According to the first come basis
3. **Removal**: Based on the **priority** of the objects
4. Key is associated when element is inserted in the priority queue;
5. Element with Minim key will be next element to be removed. 

***

## Heaps Data Structure:

1. Collection of objects or lements stored as a binary tree

2. *AKA* Binary Heap

3. ***Relational Property***: Key in each node of the binary tree is greater than or equal to those in its children.

4. ***Structural Property***: Binary tree should be a complete binary tree

5. Max Heap: if each node of the binary tree is greater than or equal to those in its children

6. Min Heap: if each node of the binary tree is smaller than or eqaul to those in its children

***

## Determin if a Binary Tree is Heap, need to bothly:
	
> 1. Satisify Max or Min Heap
>
> 2. is a Complete Tree ***(No Gaps)***


## Heaps Abstract Data Type:

### Members:

- Max Size

- Current Size

***

### Operations:

- `Insert(Object)`: Insert Element in the Heap

- `DeleteMax()`: Delete and Return the Maximum Element from the Heap

- `Max()`: Return the Max Element from the Heap