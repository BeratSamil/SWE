import lib1

import unittest

class Triangle(unittest.TestCase):
    def test1(self):
        self.assertEqual(lib1.triangleIneq(1,1,1),"possible")
        self.assertEqual(lib1.triangleIneq(3,4,5),"possible")
        self.assertEqual(lib1.triangleIneq(3,3,5),"not possible")



if __name__=='__main__':
    unittest.main()
