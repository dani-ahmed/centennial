# import required modules
from sklearn.linear_model import LinearRegression
from sklearn.model_selection import train_test_split
import numpy as np
import pandas as pd
import os

#load data into dataframe
path = "C:/Users/daniy/Desktop/SEM3/INTRO TO AI (PYTHON)/Lab Assignment 3/Exercise#2_Daniyal"
filename = 'Ecom Expense.csv'
fullpath = os.path.join(path,filename) 
ecom_exp_daniyal = pd.read_csv(fullpath)

#display first 3 records
print(ecom_exp_daniyal.head(3))
#display shape of dataframe
print(ecom_exp_daniyal.shape)
#display the column names
print(ecom_exp_daniyal.columns)
#display types of columns
print(ecom_exp_daniyal.dtypes)
#display missing values in each column
print(ecom_exp_daniyal.isnull().sum())

#transform categorical variables (catvars) to numeric using get_dummies 
catvars=['Gender', 'City Tier']
for var in catvars:
    catlist = pd.get_dummies(ecom_exp_daniyal[var], prefix=var)
    ecom_exp_daniyal = ecom_exp_daniyal.join(catlist)
    
# drop original categorical columns
ecom_exp_daniyal = ecom_exp_daniyal.drop(catvars, axis = 1)
# drop transaction id column
ecom_exp_daniyal = ecom_exp_daniyal.drop('Transaction ID', axis = 1)

#function that normalizes all points in dataframe using formula
def normalize(df):
    normalizeddf = (df - df.min()) / (df.max() - df.min())
    return normalizeddf

# use normalize function on the dataset
ecom_exp_daniyal = normalize(ecom_exp_daniyal)

# print first 2 records
print(ecom_exp_daniyal.head(2))

# plot histogram showing all variables
ecom_exp_daniyal.hist(figsize = (9, 10))

# plot scattermatrix with alpha = 0.4 and figsize = 13x15
pd.plotting.scatter_matrix(ecom_exp_daniyal[['Age',
                                             'Monthly Income',
                                             'Transaction Time',
                                             'Total Spend']], alpha = 0.4, figsize = (13, 15))

#create data to turn into train and test data using predictor variables and output variable 'Total Spend'
featurecols = ['Monthly Income', 
               'Transaction Time', 
               'Gender_Female', 
               'Gender_Male',
               'City Tier_Tier 1', 
               'City Tier_Tier 2', 
               'City Tier_Tier 3']
x = ecom_exp_daniyal[featurecols]
y = ecom_exp_daniyal['Total Spend']

#split data into training and testing data
x_train_daniyal, x_test_daniyal, y_train_daniyal, y_test_daniyal = train_test_split(x, y, test_size = 0.35)

# sets seed to 72
np.random.seed(72)

#build linear regression model using training data
lr = LinearRegression()
lr.fit(x_train_daniyal, y_train_daniyal)

# display coefficients 
print(lr.coef_)
# display model score(r-squared)
print(lr.score(x_train_daniyal, y_train_daniyal))

# adds 'Record' to the feature list
featurecols2 = ['Monthly Income', 
                'Transaction Time', 
                'Record', 
                'Gender_Female', 
                'Gender_Male',
                'City Tier_Tier 1', 
                'City Tier_Tier 2', 
                'City Tier_Tier 3']
x = ecom_exp_daniyal[featurecols2]
y = ecom_exp_daniyal['Total Spend']

# splits into training and testing data
x_train_daniyal, x_test_daniyal, y_train_daniyal, y_test_daniyal = train_test_split(x, y, test_size = 0.35)
 
# sets seed to 72
np.random.seed(72)
 
# builds a linear regression model using training data
lr = LinearRegression()
lr.fit(x_train_daniyal, y_train_daniyal)
 
# display coefficients
print(lr.coef_)
# display score/rsquared value
print(lr.score(x_train_daniyal, y_train_daniyal))