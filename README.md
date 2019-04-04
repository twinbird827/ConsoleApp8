ConsoleApp8
====

## Overview

ポーカー https://qiita.com/Nabetani/items/cbc3af152ee3f50a822f

## Description

5枚のカードを示す文字列を入力とし、ポーカーの役を出力せよ。 ただし:

一枚のカードは、スートを表す文字＋ランクを表す文字列 で構成される。 スートを表す文字は、S, H, D, C のいずれか ランクを表す文字列は、2, 3, ..., 9, 10, J, Q, K, A のいずれか 下表の役に対応すること。下表の役に該当しない場合は '--' を出力すること。 カードはジョーカーを含まない52枚から5枚が選ばれる。 不正な入力への対応は不要。

対応すべき役と、その役だった場合に出力する文字列は以下のとおり：

フォーカード : 4K フルハウス : FH スリーカード : 3K ツーペア : 2P ワンペア : 1P 上記のいずれにも該当しない : -- 例えば、入力が「D3C3C10D10S3」ならフルハウスなので「FH」と出力する。 入力が「S8D10HJS10CJ」ならツーペアなので「2P」と出力する。

## Requirement

.NET Framework 4.5.2

## Licence

[MIT](https://github.com/twinbird827/ConsoleApp8/blob/master/LICENSE)

## Author

[twinbird827](https://github.com/twinbird827)