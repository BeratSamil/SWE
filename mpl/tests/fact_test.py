import factorial
import unittest

class FactorialTest(unittest.TestCase):
    def test1(self):
        self.assertEqual(factorial.factorial(10),3628800)
    def test2(self):
        self.assertEqual(factorial.factorial(3),6)
    def test3(self):
        self.assertEqual(factorial.factorial(5),120 )

if __name__=='__main__':
    unittest.main()
