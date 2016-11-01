def tax(bill):
    """Adds 9% tax to a restaurant bill."""
    bill *= 1.09
    print ("With tax: %f" % bill)
    return bill

def tip(bill):
    """Adds 16% tip to a restaurant bill."""
    bill *= 1.16
    print ("With tip: %f" % bill)
    return bill
    
meal_cost = 100
meal_with_tax = tax(meal_cost)
meal_with_tip = tip(meal_with_tax) 
