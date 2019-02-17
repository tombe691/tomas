import unittest

def multiply(a, b)

class testUM(unittest.TestCase):

    def test_numbers(self):
        self.assertEqual(12, multiply(3, 4))

    def test_strings(self):
        self.assertEqual('aaa', multiply('a', 3)


if __name__ == '__main__':
    unittest.main()



