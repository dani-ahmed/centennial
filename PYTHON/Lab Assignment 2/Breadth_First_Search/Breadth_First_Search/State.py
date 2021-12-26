'''
@author: Devangini Patel
'''
from GraphData import *
import sys

class State:
    '''
    This class retrieves state information for social connection feature
    '''
    
    def __init__(self, graph, name, goalState):
            self.name = name
            self.goalState = goalState
            #check if args exist
            
            try: 
                eGraph = eval(graph)
            except:
                print("Graph not defined, exiting")
                sys.exit()
            if name not in eGraph:
                print("Start name not found in graph, exiting")
                sys.exit()
            if goalState not in eGraph:
                print("Goal name not found in graph, exiting")
                sys.exit()
            
            self.graph = eGraph
    # def getInitialState(self):
    #     """
    #     This method returns me.
    #     """
    #     initialState = ""
    #     return initialState


    def successorFunction(self):
        """
        This is the successor function. It finds all the persons connected to the
        current person
        """
        return self.graph[self.name]
        
        
    def checkGoalState(self):
        """
        This method checks whether the person is the goal person.
        """ 
        #check if the person's name is what was passed
        return self.name == self.goalState