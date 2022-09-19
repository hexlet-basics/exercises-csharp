#!/bin/bash

# scriptcs Test.csx 2>&1

# TODO: при возникновении ошибок компиляции в подключаемых файлах с помощью #load
# выполнение скрипта завершается с кодом 0, то есть не считается ошибкой.
# Нужно найти грамотное решение. Временное решение с помощью bash:

OUTPUT=$(scriptcs Test.csx 2>&1)
exit_code=$?
echo "$OUTPUT"

if [ ! $exit_code -eq 0 ]; then
  exit $exit_code;
fi

if [ ! -z "$OUTPUT" ]; then
  MATCHES_COUNT=$(grep -c 'error CS' <<< $OUTPUT) || true
  [ $MATCHES_COUNT == "0" ]
fi
