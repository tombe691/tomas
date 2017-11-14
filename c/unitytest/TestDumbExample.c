#include "unity/src/unity.h"
#include "DumbExample.h"

void test_AddTwoNumbers(void)
{
  TEST_ASSERT_EQUAL_FLOAT(4.0, AddTwoNumbers(2.0, 2.0));
}

int main(void)
{
  UNITY_BEGIN();
  RUN_TEST(test_AddTwoNumbers);
  return UNITY_END();
}
