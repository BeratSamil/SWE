import adding
import unittest

class AddingTest(unittest.TestCase):
    def test1(self):
        self.assertEqual(adding.add(5,5),10)


if __name__=='__main__':
    unittest.main()
