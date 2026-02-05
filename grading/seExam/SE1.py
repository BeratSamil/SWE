import unittest

def checkDivision(number):
    return number%3==0 or number%5==0




class DivisionTest(unittest.TestCase):
    def test1(self):
        self.assertEqual(checkDivision(5),True)
    def test2(self):
        self.assertEqual(checkDivision(10),True)
    def test3(self):
        self.assertEqual(checkDivision(15),True)
    def test4(self):
        self.assertEqual(checkDivision(34),False)
    def test5(self):
        self.assertEqual(checkDivision(43),False)

if __name__=='__main__':
    unittest.main()