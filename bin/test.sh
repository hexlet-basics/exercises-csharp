#!/bin/bash

# scriptcs Test.csx 2>&1

# TODO: при возникновении ошибок компиляции в подключаемых файлах с помощью #load
# выполнение скрипта завершается с кодом 0, то есть не считается ошибкой.
# Нужно найти грамотное решение. Временное решение с помощью bash:

set -e

{ OUTPUT=$(scriptcs Test.csx 2>&1 | tee /dev/fd/5); } 5>&1

if [ ! -z "$OUTPUT" ]; then
  MATCHES_COUNT=$(grep -c 'error CS' <<< $OUTPUT)
  [ $MATCHES_COUNT == "0" ]
fi
