'''
@author: Devangini Patel

'''

'''
Edited by Daniyal Ahmed for COMP237 "Search" Lab Assignment
'''

from Node import Node
from State import State
from collections import deque

def BFS_Daniyal(graph_name, start, end):
    """
    This function performs BFS search using a queue
    """
    graph = None
    graph = eval("graph_name")
    
    
    #create queue
    queue = deque([]) 
    #since it is a graph, we create visited list
    visited = [] 
    #create root node
    initialState = State(graph, start, end)
    root = Node(initialState)
    #add to queue and visited list
    queue.append(root)    
    visited.append(root.state.name)
    # check if there is something in queue to dequeue`
    print("Graph defined")
    print("Path that node takes to find route: ")
    while len(queue) > 0:
        
        #get first item in queue
        currentNode = queue.popleft()
        
        print (currentNode.state.name, ("->"), end=' ')
        
        #check if this is goal state
        if currentNode.state.checkGoalState():
            print()
            print (start, " was able to connect with ", end, "!")
            #print the path
            print ("----------------------")
            print ("Path")
            currentNode.printPath()
            break
        #get the child nodes 
        childStates = currentNode.state.successorFunction()
        for childState in childStates:
            
            childNode = Node(State(graph, childState, end))
            
            #check if node is not visited
            if childNode.state.name not in visited:
                
                #add this node to visited nodes
                visited.append(childNode.state.name)
                
                
                #add to tree and queue
                currentNode.addChild(childNode)
                queue.append(childNode)             
        if (len(queue) == 0 and currentNode.state.checkGoalState):
            print()
            print(start, " is not able to establish a connection to ", end)
            return
    print ("----------------------")
    print ("Tree: ")
    root.printTree()
    print ("----------------------")
                
#all parameters defined
BFS_Daniyal("connections", "Daniyal", "Dolly")

#all parameters defined
BFS_Daniyal("connections", "George", "Bob")

#undefined graph name
#BFS_Daniyal("connection", "Daniyal", "Dolly")

#undefined start name
#BFS_Daniyal("connections", "Dani", "Dolly")

#undefined end name
#BFS_Daniyal("connections", "Daniyal", "Doll")