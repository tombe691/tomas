#include "unity/src/unity.h"
#include "main2_refactored.h"

void test_MultiplyTwoNumbers(void)
{
  TEST_ASSERT_EQUAL_FLOAT(6.0, eff_enk(2.0, 3.0));
}

int main(void)
{
  UNITY_BEGIN();
  RUN_TEST(test_MultiplyTwoNumbers);
  return UNITY_END();
}
