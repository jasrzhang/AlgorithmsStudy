# Graphs:

Graphs represents relationship between objects
Collection of objects along with pairwise connection between objects


## Terms:
***

- Graph is a collection of object called as Vertices and together with relationship between them called as Edges	

- Graph(G) = {V,E}
	- Each Edge in the Graph joins two vertices
	- Vertices(V) = {A, B, C ,D}


***Directed Edge***:

> An **edge(u,v)** is directed if pair (u,v) is ordered, with u preceding v.
> -> Edge is oriented or Direction


***Undirected Edge***: 

> An **edge (u,v)** is undirected if pair (u,v) is not ordered. 
> -> Edge has no orientation

***Weighted Edge***: 

> If a cost or a weight is assigned to an edge, then the edge is known as a **Weighted Edge**. 

***Weighted Undirected Graph***: 

> All edgeds of the undirected graph have weights or costs assgined

***End Vertices***: 

> Two vertices joined by an edge.

***Adjacent Vertices***:  

> Two vertices are adjancent if there is an edge between them.

***Incident Edge***: 

> If vertex is **one** of the end points. 

***Outgoing Edges***: 

> Origin is the vertex

***Incoming Edges***:

> Destination is the vertex

***Self loop***

> **From** and **On** the same vertex

***Parallel Edges***:

> Edge from ** u to v (u,v) **as well as an edge from ** v to u (v,u)**

***Degree of Vertex***:

	Checks how many Edges a Vertex has;	
	
	e.g. if A has 3 edges, then the degree of A is 3.

 - ***In-Degree:*** number of incoming edges
 - ***Out-Degree:*** number of outgoing edges

### Path:
***Path***:
> is sequence of edges starting at one vertext and ending at another vertex

***Cycle***:
> is path that starts and ends at the same vertex

***Directed Acyclic Graph***:
> is When there are no cycles in a directed graph

## Sub-graph
 ***Subgraph***
> is whose vertices and edges are subset of vertices and edges of anpther graph

***Connected Components***
> Connected subgraphs are known as connected components

***Articulation Point***
> vertex whose removal results in connected components spliting into more than *one* comonent

***Strongly Connected Graph***
> **All** the vertices are reachable from **any** vertex

***

## Graphs - Abstract Data Type (ADT)

> - `Create(n)`: Creates graph with n vertices and **no** edges
>
>- `Insert_Edges(u, v, w = 1)`: Creates Edge from u to v, storing weight w (by default 1)
>
>- `Remove_Edge(u, v)`: deletes edge from u to v
>
>- `Exsit_Edge(u, v)`: returns tru if edge exists between u and v, else false
>
>- `Vertex_Count()`: returns number of vertices in the graph
>	
>- `Edge_Count`: returns number of edges in the graph
>	
>- `Vertices()`: returns all the vertices of the graph
>	
>- `Edges()`: returns all the edges of the graph
>	
>- `Degree()`: returns the degree of the vertex u
>	
>- `Indegree(u)`: returns the indegree of the vertex u
>	
>- `OutDegree(u)`: returns the outdegree of the vertex u
***

## Presentation

***Edge List***:
> Maintains list of all edges.
>
> Vertext is stored in a List and Edges stored in a list too. 
>
> Can use `Linedlist` or `DoublyLinkedList`


***Adjacency List***:
>For each vertex, separate list of edges is maintained

***Adjancency Maxtrix***:
> Maintains a maxtrix of vertices, where each cell stores the reference to the edge
***

# Graph Traversals

As the structrure is neither Linear/Linked/Heap/Stack/Queue, need other measure to traversal the Graphs

> - Traversal is a systematic procedure of exploring a graph
>
> - Exploring: Examining all the vertices and edges of the graph
>
> - Efficient Traversal: Visits to all vertices and edges is in linear time
	

## Graph Traversals - Udirected Graphs

> - Computing a path from one vertex to another vertex
>
> - Compute path to reach all other vertices
>
> - Find whether a graph is connected 
>
> - Computing connected components of the graph
>
> - Computing Cycle in a graph
>
> - Computing spanning tree of the graph
	

## Graph Traversals - Directed Graphs

> - Computing **direct path** from one vertex to another vertex
>
> - Finding ***all the vertices*** that can be **reachable** from a given vertex
>
> - Determine whether a graph is strongly connected
>
> - Determin whether a graph is acyclic


### Traversal Algoriths - **Breadth First**

#### Strategy:

> - Subdivides the vertices into levels and proceeds in rounds
>
> - Starts at a **vertex**, which is considered at **level 0**
>
> - Identifies **all the vertices reachable** from starts vertext at **level 1**, marks them visited
>
> - In next round, identifies new vertices **reachable** from **level 1** vertices which are not yet visited, marks then visited.
>
> - This process continues until no vertices are found.

### Traversal Algoriths - **Depth First**

#### Strategy:

> - Starts at a **vertex**
>
> - Selects the **adjacent vertex** from the start vertex
>
> - Visit the adjacent vertex, mark as visited
>
> - Continue the above prodedure, untile there are no more unexplored edges, then ternimate