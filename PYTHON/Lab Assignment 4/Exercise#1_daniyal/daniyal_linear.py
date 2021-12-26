#import required modules
from sklearn.linear_model import LogisticRegression
from sklearn.model_selection import cross_val_score
from sklearn.model_selection import train_test_split
from sklearn.metrics import confusion_matrix
from sklearn.metrics import accuracy_score
from sklearn.metrics import classification_report
import matplotlib.pyplot as plt
import numpy as np
import pandas as pd
import os
 
# loads the data in a pandas dataframe
filename = 'titanic.csv'
path = 'C:/Users/daniy/Desktop/SEM3/INTRO TO AI (PYTHON)/Lab Assignment 4/Exercise#1_daniyal'
fullpath = os.path.join(path, filename)
titanic_daniyal = pd.read_csv(fullpath)
 
# print first 3 records
print(titanic_daniyal.head(3))
# print shape of dataframe
print(titanic_daniyal.shape)
# print dataframe info
print(titanic_daniyal.info())
 
# prints unique values for Sex column
print(titanic_daniyal['Sex'].unique())
# prints unique values for Pclass column
print(titanic_daniyal['Pclass'].unique())
 
# prints crosstab of survived vs pclass
pd.crosstab(titanic_daniyal['Survived'], titanic_daniyal['Pclass']).plot(kind = 'bar')
plt.title('# Survived vs Passenger Class')
plt.xlabel('Passenger Class')
plt.ylabel('# of Survivors')
 
# prints crosstab of survived vs gender
pd.crosstab(titanic_daniyal['Survived'], titanic_daniyal['Sex']).plot(kind = 'bar')
plt.title('# Survived vs Gender')
plt.xlabel('Gender')
plt.ylabel('# of Survivors')
 
# plots a scattermatrix
pd.plotting.scatter_matrix(titanic_daniyal[['Sex', 
                                            'Pclass', 
                                            'Fare', 
                                            'SibSp', 
                                            'Parch']], 
                           alpha=0.4, figsize=(13,15))
 
# drops passengerId, name, ticket, cabin
titanic_daniyal = titanic_daniyal.drop(['PassengerId', 
                                        'Name', 
                                        'Ticket', 
                                        'Cabin'], axis = 1)
 
# converts categorical data into numeric data using get_dummies
catvars = ['Sex', 'Embarked']
for var in catvars:
    catlist = pd.get_dummies(titanic_daniyal[var], prefix = var)
    titanic_daniyal = titanic_daniyal.join(catlist)
    
# drops original categorical columns
titanic_daniyal = titanic_daniyal.drop(catvars, axis = 1)
 
# fills NaN with mean in age column
titanic_daniyal = titanic_daniyal.fillna(titanic_daniyal.mean())
 
# converts df columns to float
for column in titanic_daniyal:
    titanic_daniyal[column] = titanic_daniyal[column].astype(float)
    
# create function to normalize all data points in a dataframe
def normalize(df):
    normalized = (df - df.min()) / (df.max() - df.min())
    return normalized
 
# call normalize function using titanic_daniyal dataset
titanic_daniyal = normalize(titanic_daniyal)

# prints first 2 records
print(titanic_daniyal.head(2))
 
# plots histogram with all variables
titanic_daniyal.hist(figsize = (9, 10))
 
# creates x and y
featurecols = ['Pclass',
               'Age',
               'SibSp',
               'Parch',
               'Fare',
               'Sex_female',
               'Sex_male',
               'Embarked_C',
               'Embarked_Q',
               'Embarked_S']

x_daniyal = titanic_daniyal[featurecols]
y_daniyal = titanic_daniyal['Survived']
 
# sets seed to 72
np.random.seed(72)
 
# split into training and testing data (70/30)
x_train_daniyal, x_test_daniyal, y_train_daniyal, y_test_daniyal = train_test_split(x_daniyal, 
                                                                                    y_daniyal, 
                                                                                    test_size = 0.3)
 
# logistic regression model
lr = LogisticRegression()
lr.fit(x_train_daniyal, y_train_daniyal)
 
# print coefficients
pd.DataFrame(zip(x_train_daniyal.columns, np.transpose(lr.coef_)))
 
# prints scores and mean score for test sample size 30%
scores = cross_val_score(LogisticRegression(solver = 'lbfgs'), x_train_daniyal, y_train_daniyal, 
                         scoring = 'accuracy', cv = 10)
#print scores
print(scores)

# print mean of scores
print(scores.mean())
 
# prints scores and mean score for test sample size from 10% to 50%
for i in np.arange (0.1, 0.5, 0.05):
    #create test and training sets
    x_train_daniyal, x_test_daniyal, y_train_daniyal, y_test_daniyal = train_test_split(x_daniyal, y_daniyal, test_size = i)
    # create and fit logistic regression model
    lr = LogisticRegression()
    lr.fit(x_train_daniyal, y_train_daniyal)
    # use cross_val_score method to cross validate the scores and put into scores field
    scores = cross_val_score(LogisticRegression(solver = 'lbfgs'), x_train_daniyal, y_train_daniyal, 
                             scoring = 'accuracy', cv = 10)
    # print out score values and mean
    print("Testing data size: ", i)
    print("Min Score: ", min(scores))
    print("Max Score: ", max(scores))
    print("Mean Score: ", scores.mean())
    print()
    
# create new model using 70/30 split
x_train_daniyal, x_test_daniyal, y_train_daniyal, y_test_daniyal = train_test_split(x_daniyal, y_daniyal, test_size = 0.3)
lr = LogisticRegression()
lr.fit(x_train_daniyal, y_train_daniyal)


#define variable y_pred_daniyal that stores predicted probabilities of model
y_pred_daniyal = lr.predict_proba(x_test_daniyal)
# define var named y_pred_daniyal_flag that transforms y_prob_daniyal into boolean values based on threshold of 0.5
y_pred_daniyal_flag = y_pred_daniyal[:, 1] > 0.5

# print accuracy of model on test data
print(accuracy_score(y_test_daniyal, y_pred_daniyal_flag))
# print out confusion matrix
print(confusion_matrix(y_test_daniyal, y_pred_daniyal_flag))
# print out classification report
print(classification_report(y_test_daniyal, y_pred_daniyal_flag))
 
# change threshold value to 0.75 and repeat previous steps
y_pred_daniyal_flag = y_pred_daniyal[:, 1] > 0.75
print(accuracy_score(y_test_daniyal, y_pred_daniyal_flag))
print(confusion_matrix(y_test_daniyal, y_pred_daniyal_flag))
print(classification_report(y_test_daniyal, y_pred_daniyal_flag))